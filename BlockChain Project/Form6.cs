using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Org.BouncyCastle.Utilities;
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
    public partial class Form6 : Form
    {
        public DataTable dt;
        public Form6()
        {
            dt = new DataTable();
            InitializeComponent();
            string[] columnnames = new string[6] { "ContractAddress", "Ethreum Address", "ProductName", "Description", "Specification", "SerialNumber" };

            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }
            using (var reader = new StreamReader(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\ContractOwner.txt"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    DisplayContract(values[0]);
                    
                }
            }
            
        }
        public bool isDecommision(string contract)
        {
            string[] s1 = File.ReadAllLines(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DecommisionContract.txt");
            int i = 0;
            foreach(String s in s1)
            {
                if(contract==s)
                {
                    i = 1;
                }
            }
            if(i==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private async Task DisplayContract(string contractaddress)
        {
            DataRow dr = dt.NewRow();
            if (!isDecommision(contractaddress))
            {
              
                var url = "http://127.0.0.1:7545";
                string eth_address1 = "0x594559a12AF7CC1085f65c53f4252535Bad12203";

                var privateKey1 = "db9820f8b4585f5f022b03e062431636dc965aff525b195cee787c1fe55fd02b";
                var account = new Account(privateKey1);
                var web3 = new Web3(account, url);
                var iot4 = new OwnerAddress();
                var balanceHandler4 = web3.Eth.GetContractQueryHandler<OwnerAddress>();
                var balance4 = await balanceHandler4.QueryAsync<String>(contractaddress, iot4);

                var iot = new ProductName();
                var balanceHandler = web3.Eth.GetContractQueryHandler<ProductName>();
                var balance = await balanceHandler.QueryAsync<String>(contractaddress, iot);


                var iot2 = new Description();
                var balanceHandler2 = web3.Eth.GetContractQueryHandler<Description>();
                var balance2 = await balanceHandler2.QueryAsync<String>(contractaddress, iot2);

                var iot3 = new SerialNumber();
                var balanceHandler3 = web3.Eth.GetContractQueryHandler<SerialNumber>();
                var balance3 = await balanceHandler3.QueryAsync<String>(contractaddress, iot3);
                string[] s = File.ReadAllLines(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DecommisionContract.txt");
                int a = 0;
                foreach (string s1 in s)
                {
                    if (s1 == contractaddress)
                    {
                        a = 1;
                    }
                }
                if (a != 1)
                {
                    dr[0] = contractaddress;
                    dr[1] = balance4;
                    dr[2] = balance;
                    dr[3] = balance2;
                    dr[4] = balance3;
                    dr[5] = balance3;
                   
                }

               
            }
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;

        }
        private void Form6_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 s = new Form2();
            s.Show();
        }
    }
}
