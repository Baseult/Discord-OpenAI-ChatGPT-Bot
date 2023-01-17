using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Channels;
using Discord.Rest;
using static System.Net.Mime.MediaTypeNames;

namespace Discord_AI_Messagebot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool bigerror = false;
        private bool _running = true;
        private DiscordSocketClient _client1;
        private readonly Dictionary<string, string> _userMessages = new Dictionary<string, string>();
        private bool answered = false;
        private string token;
        List<ulong> sentMessageIds = new List<ulong>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            token = aitoken.Text;

            _client1 = new DiscordSocketClient();

            _client1.MessageReceived += MessageReceived;

            _client1.LoginAsync(TokenType.User, DiscordTokenText.Text).GetAwaiter().GetResult();
            _client1.StartAsync().GetAwaiter().GetResult();

            _running = true;
            textBox1.Text += "Status: Bot Running!";
            label1.Text = "Status: Bot Running!";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _running = false;
            label1.Text = "Status: Bot Stopped!";
            textBox1.Text += "Status: Bot Stopped!";
        }

        private static string GetResponse(string openAiKey, string input, int tokens, string engine, double temperature, double topP, int bestof, double frequencyPenalty, double presencePenalty, string stop)
        {
            const int timeout = 30000;
            const string apiCall = "https://api.openai.com/v1/completions";

            if (input.Contains('"') || input.Contains("\n"))
            {
                input = input.Replace("\"", "'");
                input = input.Replace("\n", "\\n");
            }

            if (tokens <= 0 || temperature < 0 || topP < 0 || bestof <= 0 || frequencyPenalty < 0 || presencePenalty < 0)
            {
                MessageBox.Show("Wrong Input");
            }

            for (var tries = 0; tries < 3; tries++)
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), apiCall))
                        {
                            request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + openAiKey);
                            request.Content = new StringContent("{\n  \"model\": \"" + engine + "\",\n  \"prompt\": \"" + input + "\",\n  \"temperature\": " + temperature.ToString(CultureInfo.InvariantCulture) + ",\n  \"max_tokens\": " + tokens + ",\n  \"top_p\": " + topP.ToString(CultureInfo.InvariantCulture) + ",\n  \"best_of\": " + bestof + ",\n  \"frequency_penalty\": " + frequencyPenalty.ToString(CultureInfo.InvariantCulture) + ",\n  \"presence_penalty\": " + presencePenalty.ToString(CultureInfo.InvariantCulture) + ",\n  \"stop\": " + stop + "\n}");
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                            using (var cancellationTokenSource = new CancellationTokenSource(timeout))
                            {
                                var responseTask = httpClient.SendAsync(request, cancellationTokenSource.Token);
                                if (responseTask.Wait(timeout))
                                {
                                    var response = responseTask.Result;
                                    var json = response.Content.ReadAsStringAsync().Result;
                                    Console.WriteLine(json);
                                    dynamic dynObj = JsonConvert.DeserializeObject(json);

                                    if (json.Contains("We could not parse the JSON body"))
                                    {
                                        bigerror = true;
                                        return null;
                                    }

                                    if (dynObj == null || dynObj.choices == null || dynObj.choices[0].text.ToString().Equals(""))
                                        continue;

                                    return dynObj.choices[0].text.ToString();
                                }

                                Console.WriteLine("The request timed out.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                    if (ex.Message.Contains("We could not parse the JSON body"))
                    {
                        bigerror = true;
                    }
                }
            }

            return null;
        }

        private async Task MessageReceived(SocketMessage message)
        {

            try
            {
                if (message.Content.Contains("!ai off"))
                {
                    _running = false;
                    var test = await message.Channel.SendMessageAsync("*AI has been turned off*");
                    sentMessageIds.Add(test.Id);
                    await test.AddReactionAsync(new Emoji("🤖"));
                    textBox1.Text += "Turned AI off";
                }
                else if (message.Content.Contains("!ai on"))
                {
                    _running = true;
                    var test = await message.Channel.SendMessageAsync("*AI has been turned on*");
                    sentMessageIds.Add(test.Id);
                    await test.AddReactionAsync(new Emoji("🤖"));
                    textBox1.Text += "Turned AI on";
                    return;
                }


                if (!_running)
                    return;

                if (sentMessageIds.Contains(message.Id))
                    return;

                if (sentMessageIds.Count > 10)
                {
                    sentMessageIds.RemoveAt(0);
                }

                textBox1.Text += "New Message Received";

                var mod = message.Channel.EnterTypingState();

                if (_userMessages.ContainsKey(message.Author.Username))
                {
                    _userMessages[message.Author.Username] += message.Content + ".";
                }
                else
                {
                    textBox1.Text += "New User Detected";
                    textBox1.Text += "Waiting for Response";
                    var AIresponse = GetResponse(token ,message.Content + "\n\n1. Explain that the user he is trying to reach is currently unavailable.\n2. Also explain that this text is written by the missing users OpenAI Chatbot and that if he needs help, he can just ask the Chatbot instead as long as the user is not there that he is trying to reach.\n3. Explain that the Chatbot adds a 🤖 Emoji behind each message, so that he knows that he is still writing with the Chatbot.\nWrite a short paragraph in english, containing all the steps above.", 200, "text-davinci-003", 0.7, 1, 1, 0.5, 0, "\"\"");
                    textBox1.Text += "Retrieved Response";

                    if (AIresponse != null)
                    {
                        if (AIresponse.StartsWith("\n\n"))
                        {
                            AIresponse = AIresponse.Substring(2);
                        }

                        textBox1.Text += "Sending AI Message";
                        var test = await message.Channel.SendMessageAsync(AIresponse);
                        sentMessageIds.Add(test.Id);
                        answered = true;
                       await test.AddReactionAsync(new Emoji("🤖"));
                        textBox1.Text += "AI Message Sended";
                    }

                    _userMessages.Add(message.Author.Username, message.Content + ".");
                }

                RestUserMessage firstMessage = await message.Channel.SendMessageAsync("*Loading please wait...*");
                sentMessageIds.Add(firstMessage.Id);
                answered = true;
                await firstMessage.AddReactionAsync(new Emoji("⌛"));

                if (_userMessages[message.Author.Username].Length > 4000)
                {
                    var charsToRemove = -3500 + _userMessages[message.Author.Username].Length;
                    _userMessages[message.Author.Username] = _userMessages[message.Author.Username].Substring(charsToRemove);

                    textBox1.Text += "Removed Chars for " + _userMessages[message.Author.Username];
                }

                if (bigerror)
                {
                    _userMessages[message.Author.Username] = "";
                    bigerror = false;
                }
                
                var usermessage = _userMessages[message.Author.Username];
                textBox1.Text += "Waiting for Response";
                var response = GetResponse(token, usermessage, 1500, "text-davinci-003", (double)Temperature.Value, (double)TopP.Value, 1, (double)FrequencyPenalty.Value, (double)PresencePenalty.Value, "\"\"");
                textBox1.Text += "Retrieved Response";

                if (response != null)
                {
                    if (response.StartsWith("\n\n"))
                    {
                        response = response.Substring(2);
                    }

                    textBox1.Text += "Sending AI Message";
                    await firstMessage.ModifyAsync(m => m.Content = response);
                    //await firstMessage.RemoveReactionAsync(new Emoji("⌛"), _client1.CurrentUser);
                    await firstMessage.AddReactionAsync(new Emoji("🤖"));
                    textBox1.Text += "AI Message Sended";

                    _userMessages[message.Author.Username] += "\\n\\n" + response.Replace("\n", "\\n").Replace(Environment.NewLine, "\nn") + "\\n\\n";
                }
                else //In case something fails
                {
                    textBox1.Text += "Response Message was empty";
                    await firstMessage.ModifyAsync(m => m.Content = "I can't answer that question");
                    //await firstMessage.RemoveReactionAsync(new Emoji("⌛"), _client1.CurrentUser);
                    await firstMessage.AddReactionAsync(new Emoji("🤖"));
                }

                mod.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

       private bool isUpdatingText = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingText)
            {
                return;
            }

            isUpdatingText = true;

            var dateTimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            textBox1.Text += $" - [{dateTimeString}]\r\n";

            isUpdatingText = false;
        }
    }
}