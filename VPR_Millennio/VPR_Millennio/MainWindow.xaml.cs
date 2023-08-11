using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VPR_Millennio.@class;

namespace VPR_Millennio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bank bank;
        public int currentMoney = -10000;

        public MainWindow()
        {
            InitializeComponent();
            lblMoneyDisplayBank.Content = "Money: " + currentMoney;
            bank = new Bank();
        }

        

        private void BtnTake10000Loan_Click(object sender, RoutedEventArgs e)
        {

            currentMoney += bank.TakeLoan(10000);
            UpdateBankUI();
        }

        private void BtnTake20000Loan_Click(object sender, RoutedEventArgs e)
        {
            currentMoney += bank.TakeLoan(20000);
            UpdateBankUI();
        }

        private void BtnTake50000Loan_Click(object sender, RoutedEventArgs e)
        {
            currentMoney += bank.TakeLoan(50000);
            UpdateBankUI();
        }

        

        private void BtnPayBack_Click(object sender, RoutedEventArgs e)
        {
            int payBackAmount = Convert.ToInt32(tbPayBackAmountBank.Text);
            if (currentMoney - payBackAmount >= 0)
            {
                bank.PayBack(payBackAmount);
                currentMoney -= payBackAmount;
                UpdateBankUI();
                
            }
            
        }

        
        private void UpdateBankUI()
        {
            lblMoneyDisplayBank.Content = "Money: " + currentMoney;
            lblCurrentLoan.Content = "Current loan: " + bank.CurrentLoan;
        }
    }
}
