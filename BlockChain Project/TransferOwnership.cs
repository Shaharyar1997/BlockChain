using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChain_Project
{
    public partial class TransferOwnership : Form
    {
        public bool isDecommision(string contract)
        {
            string[] s1 = File.ReadAllLines(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DecommisionContract.txt");
            int i = 0;
            foreach (String s in s1)
            {
                if (contract == s)
                {
                    i = 1;
                }
            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TransferOwnership()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\ContractOwner.txt"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if(!isDecommision(values[0]))
                        {
                        comboBox1.Items.AddRange(new string[] { values[0] });
                    }
                    

                }

            }
            comboBox2.Items.AddRange(new string[] { "Patient","Clinic"});
        }

        private void TransferOwnership_Load(object sender, EventArgs e)
        {

        }
      
        public void contractOwnerUpdate(string contractaddress)
        {

        }
        private async Task transferOnwer2(string contractaddress, string privatekey1, string eth_owner)
        {
            var url = "http://127.0.0.1:7545";
            var account = new Account(privatekey1);
            var web31 = new Web3(account, url);
            var iot = new TransferOwnerShips
            {
                newOwner = eth_owner
        };
        var balanceHandler = web31.Eth.GetContractQueryHandler<TransferOwnerShips>();
            var balance = await balanceHandler.QueryAsync<int>(contractaddress, iot);
            if (balance == 1)
            {
                MessageBox.Show("OwnerShipTransfer Successfully");
               
            }
            this.Hide();
            Form2 s = new Form2();
            s.Show();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string contractaddress = comboBox1.Text;
            string Owner = comboBox2.Text;

            if(Owner=="Patient")
            {
                MessageBox.Show("Pate");
                string path_address = "0xe3B811cca2012D6118491efB777c1b8893ADceaB";
                string eth_address1 = "0x594559a12AF7CC1085f65c53f4252535Bad12203";

                var privatekey1 = "db9820f8b4585f5f022b03e062431636dc965aff525b195cee787c1fe55fd02b";
                transferOnwer2(contractaddress, privatekey1,path_address);
                
            }
            else if(Owner=="Clinic")
            {
                string clinic_address = "0x1aaE918c19A475dBa7b1c88eB3A7bFd0F2c357b4";
                
                string eth_address1 = "0x594559a12AF7CC1085f65c53f4252535Bad12203";

                var privatekey1 = "db9820f8b4585f5f022b03e062431636dc965aff525b195cee787c1fe55fd02b";
                transferOnwer2(contractaddress, privatekey1,clinic_address);


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 s = new Form2();
            s.Show();
        }
    }
}
