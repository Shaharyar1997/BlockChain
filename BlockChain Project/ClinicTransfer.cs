using Nethereum.Model;
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
using Nethereum.Web3.Accounts;
using Nethereum.Web3;
namespace BlockChain_Project
{
    public partial class ClinicTransfer : Form
    {
        public ClinicTransfer()
        {
            InitializeComponent();
        }

        private void ClinicTransfer_Load(object sender, EventArgs e)
        {

        }
        private async Task transferOnwer2(string contractaddress, string privatekey1, string privatekey2, string eth_owner)
        {
            var url = "http://127.0.0.1:7545";
            var account = new Nethereum.Web3.Accounts.Account(privatekey1);
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
                using (var reader = new StreamReader(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DeployedContract.txt"))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (contractaddress == values[0])
                        {
                            var csv = new StringBuilder();

                            //in your loop
                            string Item1 = values[0];
                            string Item2 = eth_owner;
                            string Item3 = values[2];
                            string Item4 = values[3];
                            string Item5 = values[4];
                            string Item6 = values[5];
                            //Suggestion made by KyleMit
                            var newLine = string.Format("{0},{1},{2},{3},{4},{5}", Item1, Item2, Item3, Item4, Item5, Item6);
                            csv.AppendLine(newLine);

                            //after your loop
                            MessageBox.Show(csv.ToString());
                            File.AppendAllText(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DeployedContract.txt", csv.ToString());

                        }
                        else
                        {
                            var csv = new StringBuilder();

                            //in your loop
                            string Item1 = values[0];
                            string Item2 = values[1];
                            string Item3 = values[2];
                            string Item4 = values[3];
                            string Item5 = values[4];
                            string Item6 = values[5];
                            //Suggestion made by KyleMit
                            var newLine = string.Format("{0},{1},{2},{3},{4},{5}", Item1, Item2, Item3, Item4, Item5, Item6);
                            csv.AppendLine(newLine);

                            //after your loop
                            MessageBox.Show(csv.ToString());
                            File.AppendAllText(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DeployedContract.txt", csv.ToString());

                        }

                    }
                }

            }
            this.Hide();
            Form2 s = new Form2();
            s.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string contractaddress = comboBox1.Text;
            string Owner = comboBox2.Text;
            if (Owner == "Manufacturer")
            {
                MessageBox.Show("Pate");
                string eth_address = "0x9Aa8694635b49D405D1E1bf8A9C9a26fDc1a987d";
                string privatekey = "7eaaa4b74cd20db0c1b6862e9b96f7d2a568366826452a80b15a1ba09dbd1e7a";
                string eth_address1 = "0x9Aa8694635b49D405D1E1bf8A9C9a26fDc1a987d";

                var privatekey1 = "87eeb49d97be2d1d338b46f27be26252802cade88ebdba741bde895332766d36";
                transferOnwer2(contractaddress, privatekey1, privatekey, eth_address1);
                using (var reader = new StreamReader(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DeployedContract.txt"))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');


                    }
                }
            }
            else if (Owner == "Patient")
            {
                string eth_address = "0x835973c60EbDA7833E4EBF8065A893cA7515963f";
                string privatekey = "b2665974fe5e5da952a7a030bac84231e45d4063056559c4b1a2062d59791ea2";
                string eth_address1 = "0x9Aa8694635b49D405D1E1bf8A9C9a26fDc1a987d";

                var privateKey1 = "87eeb49d97be2d1d338b46f27be26252802cade88ebdba741bde895332766d36";
                transferOnwer2(contractaddress, privateKey1, privatekey, eth_address);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
