using System.Diagnostics;

namespace moneyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string money_types = comboBox1.SelectedItem.ToString();

            string money_type = money_types.Substring(money_types.Length - 3);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"api.py \"{money_type}\" \"try\" \"{textBox1.Text}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string formatted = string.Format("{0:F4}", output);

            label3.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string money_types = comboBox2.SelectedItem.ToString();

            string money_type = money_types.Substring(money_types.Length - 3);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"api.py\" \"try\" \"{money_type}\" \"{textBox2.Text}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string formatted = string.Format("{0:F4}", output);

            label5.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string money_types = comboBox3.SelectedItem.ToString();
            string money_types2 = comboBox4.SelectedItem.ToString();

            string money_type = money_types.Substring(money_types.Length - 3);
            string money_type2 = money_types2.Substring(money_types2.Length - 3);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"api.py\" \"{money_type}\" \"{money_type2}\" \"{textBox3.Text}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();

            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            string formatted = string.Format("{0:F4}", output);

            label7.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"api.py\" \"usd\" \"try\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            MessageBox.Show(output);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"api.py\" \"eur\" \"try\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            MessageBox.Show(output);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"api.py\" \"chf\" \"try\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            MessageBox.Show(output);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"api.py\" \"gbp\" \"try\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            MessageBox.Show(output);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
