using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
   public partial class RandomForm : Form
   {
      public RandomForm()
      {
         InitializeComponent();

      }

      Random randomNumber = new Random();
      private void GenerateButton_Click(object sender, EventArgs e)
      {

         int random = randomNumber.Next(1, 100);

         RandomLabel.Text = random.ToString();
      }
   }
}
