namespace RPGgame
{
    //will fix it later. 'string material = rarity[index];' this line is broken.

    public partial class Form1 : Form
    {

        //this is the rarity system and the variables and the rng that i declare
        double multiplier = 1.0; // base multiplier
        int gold, exp, level;
        Random rng = new Random();
        List<(string name, double weight)> rarity = new List<(string, double)> //materials in the game and thei rarity
        {
            ("Diamond", 0.02),
            ("Ruby", 0.50),
            ("Emerald", 1.50),
            ("Gold", 5),
            ("Iron", 15),
            ("Stone",40),
            ("Wood", 70)
        };
        private List<(string name, int price)> shopItems = new List<(string, int)> //multipliers and prices
{
    ("Multiplier x2", 25000),
    ("Multiplier x4", 50000),
    ("Multiplier x6", 75000)
};
        private List<string> inventory = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //button click, get gold system
            int goldrng = rng.Next(1, 501);
            gold += (int)(goldrng * multiplier);
            label6.Text = gold.ToString();

            //same thing with xp
            int xprng = rng.Next(1, 1001);
            exp += (int)(xprng * multiplier);
            label7.Text = exp.ToString();

            //this will be the rarity system which you can add to the listbox1
            string material = GetRandomMaterial();

            listBox1.Items.Add(material);

            if (material == "Diamond" || material == "Ruby" || material == "Emerald")
            {
                MessageBox.Show("You found a very rare item!");
            }

        }
        //rarity of the material formulas and the implementation
        private string GetRandomMaterial()
        {
            double totalweight = rarity.Sum(r => r.weight);
            double roll = rng.NextDouble() * totalweight; // roll between 0 and totalweight
            double sum = 0;

            foreach (var r in rarity)
            {
                sum += r.weight;
                if (roll <= sum)
                {
                    return r.name;
                }
            }

            return rarity.Last().name; // fallback
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //clearing items button
            DialogResult result = MessageBox.Show(
        "Are you sure you want to clear the list?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Request cancelled.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //level system
            if (exp >= 15000 && gold >= 2000)
            {
                level++;
                label8.Text = level.ToString();
                exp -= 15000;
                label7.Text = exp.ToString();
                gold -= 2000;
                label6.Text = gold.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Instead of "under construction", open a basic shop window
            string shopText = "Shop Items:\n";
            for (int i = 0; i < shopItems.Count; i++)
            {
                shopText += $"{i + 1}. {shopItems[i].name} - {shopItems[i].price} gold\n";
            }

            // Show items + gold + inventory
            string invText = inventory.Count > 0 ? string.Join(", ", inventory) : "None";
            shopText += $"\nYou have {gold} gold.\nEnter item number to buy. Your items: {invText}";

            string input = Microsoft.VisualBasic.Interaction.InputBox(shopText, "Shop");

            //multiplier mechanic
            if (int.TryParse(input, out int choice))
            {
                int index = choice - 1;
                if (index >= 0 && index < shopItems.Count)
                {
                    var item = shopItems[index];
                    if (gold >= item.price)
                    {
                        gold -= item.price;
                        label6.Text = gold.ToString();
                        inventory.Add(item.name);

                        if (item.name.StartsWith("Multiplier"))
                        {
                            string[] parts = item.name.Split('x');
                            if (parts.Length == 2 && double.TryParse(parts[1], out double newMult))
                            {
                                multiplier *= newMult;
                                MessageBox.Show($"Your multiplier is now x{multiplier}!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough gold!");
                    }
                }

            }
        }
    }
}
