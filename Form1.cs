using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Voice_Recognization
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btn_disable.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Choices commands = new Choices();
                commands.Add(new string[] { "say hello", "Print my name","Speak selected text" });
                GrammarBuilder gbuilder = new GrammarBuilder();
                gbuilder.Append(commands);
                Grammar grammar = new Grammar(gbuilder);

                recEngine.LoadGrammarAsync(grammar);
                recEngine.SetInputToDefaultAudioDevice();
                recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
            }catch(Exception ex)
            {
                MessageBox.Show("Error= " + ex.ToString());
            }
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "say hello":
                    PromptBuilder builder = new PromptBuilder();

                    builder.StartSentence();
                    builder.AppendText("Hello sir");
                    builder.EndSentence();

                    builder.AppendBreak(PromptBreak.ExtraSmall);

                    builder.StartSentence();
                    builder.AppendText("How you doing?", PromptEmphasis.Strong);
                    builder.EndSentence();

                    synthesizer.SpeakAsync(builder); 
                    break;

                case "print my name":
                    richTextBox.Text+="\nName is = Subhojit";
                    break;

                case "Speak selected text":
                    synthesizer.SpeakAsync(richTextBox.SelectedText);
                    break;
            }
        }

        private void btn_disable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btn_disable.Enabled = false;

        }
    }
}