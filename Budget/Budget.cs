namespace Budget
{
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            CurrentAccount instance = CurrentAccount.Instance;
            int currency = 0;
            try
            {
                currency = Int32.Parse(textBox1.Text);
            }
            catch (FormatException ex)
            {
                System.Diagnostics.Debug.WriteLine("invalid text to integer conversion");
            }
            instance.SubtractAmount(currency);   
            CurrentAccountAmount.Text = instance.amount.ToString();
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CurrentAccount instance = CurrentAccount.Instance;
            int currency = 0;
            try
            {
                currency = Int32.Parse(textBox1.Text);
            }
            catch (FormatException ex)
            {
                System.Diagnostics.Debug.WriteLine("invalid text to integer conversion");
            }
            instance.AddAmount(currency);
            CurrentAccountAmount.Text = instance.amount.ToString();
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            List<IReport> reports = new List<IReport>();
            reports.Add(new Reports());
            reports.Add(new MonthlyReport());
            reports.Add(new YearlyReport());

            comboBox1.DataSource = reports;
            this.comboBox1.SelectedIndex = 0;

            CurrentAccount instance = CurrentAccount.Instance;
            CurrentAccountAmount.Text = instance.amount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IReport report = (IReport)comboBox1.SelectedItem;
            System.Diagnostics.Debug.WriteLine(report);
            if (report.ToString() == "MonthlyReport")
            {
                Form1 reportWindow = new Form1();
                reportWindow.Show();
            }
        }
    }
}