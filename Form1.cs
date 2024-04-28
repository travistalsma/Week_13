using PokeAPI;
using Newtonsoft.Json;

namespace Pokemon_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // in async method

            //PokemonSpecies p = await DataFetcher.GetApiObject<PokemonSpecies>(395);
            // or:
            //PokemonSpecies p = await DataFetcher.GetNamedApiObject<PokemonSpecies>("lucario");

            //float cRate = p.CaptureRate;

        }

        public async void GetSpecies()
        {
            PokemonSpecies p = await DataFetcher.GetNamedApiObject<PokemonSpecies>(textBox1.Text);
            //textBox1.Text = p.Name;
            textBox2.Text = p.BaseHappiness.ToString();
            textBox3.Text = p.CaptureRate.ToString();
            textBox4.Text = p.Habitat.Name;
            textBox5.Text = p.GrowthRate.Name;
            textBox6.Text = p.EggGroups[0].Name;
            textBox7.Text = p.FlavorTexts[0].FlavorText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSpecies();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
