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
using System.Data.SqlClient;
using VPR_Millennio.enumeration;

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
            GebaeudeDatabase database = new GebaeudeDatabase();

            List<Gebaeude> mitglieder = database.SelectAll();

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


        private void OnSpielStartenClicked(object sender, RoutedEventArgs e)
        {
            SpielstandButtonsContainer.Visibility = Visibility.Visible;
            HorizontalButtonsContainer.Visibility = Visibility.Visible;
        }

        private void OnSpielstand1Clicked(object sender, RoutedEventArgs e)
        {
            ShowSelectedSpielstand("Spielstand 1");
        }

        private void OnSpielstand2Clicked(object sender, RoutedEventArgs e)
        {
            ShowSelectedSpielstand("Spielstand 2");
        }

        private void OnSpielstand3Clicked(object sender, RoutedEventArgs e)
        {
            ShowSelectedSpielstand("Spielstand 3");
        }

        private void OnSpielstand4Clicked(object sender, RoutedEventArgs e)
        {
            ShowSelectedSpielstand("Spielstand 4");
        }

        private void OnSpielstand5Clicked(object sender, RoutedEventArgs e)
        {
            ShowSelectedSpielstand("Spielstand 5");
        }

        private void OnSpielstandLadenClicked(object sender, RoutedEventArgs e)
        {
            ShowStatusText("Spielstand wurde geladen");
        }

        private void OnSpielstandLoeschenClicked(object sender, RoutedEventArgs e)
        {
            ShowStatusText("Spielstand wurde gelöscht");
        }

        private void OnNeuesSpielClicked(object sender, RoutedEventArgs e)
        {
            ShowStatusText("Neues Spiel wurde gestartet");
        }

        private void ShowSelectedSpielstand(string spielstandName)
        {
            SelectedSpielstandTextBlock.Text = "Der ausgewählte Spielstand ist: " + spielstandName;
        }

        private void ShowStatusText(string statusText)
        {
            SelectedSpielstandTextBlock.Text = statusText;
        }
        //



        #region InGameMenu
        private void BackToGame_Click(object sender, RoutedEventArgs e)
        {
            DockPanelInGameMenu.Visibility = Visibility.Hidden;
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            DockPanelInGameMenu.Visibility = Visibility.Hidden;
            DockPanelInGame.Visibility = Visibility.Hidden;
            DockPanelHauptMenue.Visibility = Visibility.Visible;
        }

        private void ExitProgram_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }
        #endregion

        #region InGame
        private void btnMenuInGame_Click(object sender, RoutedEventArgs e)
        {
            DockPanelInGameMenu.Visibility = Visibility.Visible;
        }

        private void btnBankInGame_Click(object sender, RoutedEventArgs e)
        {
            StackPanelBank.Visibility = Visibility.Visible;
            DockPanelInGame.Visibility = Visibility.Hidden;
        }

        private void btnLagerInGame_Click(object sender, RoutedEventArgs e)
        {
            DockPanelLager.Visibility = Visibility.Visible;
            DockPanelInGame.Visibility = Visibility.Hidden;
        }
        private void btnMarktInGame_Click(object sender, RoutedEventArgs e)
        {
            DockPanelMarkt.Visibility = Visibility.Visible;
            DockPanelInGame.Visibility = Visibility.Hidden;
        }
        #endregion

        #region Lager
        private void btnExitLager_Click(object sender, RoutedEventArgs e)
        {
            DockPanelLager.Visibility = Visibility.Hidden;
            DockPanelInGame.Visibility = Visibility.Visible;
        }
        #endregion

        #region Markt
        private void btnExitMarkt_Click(object sender, RoutedEventArgs e)
        {
            DockPanelMarkt.Visibility = Visibility.Hidden;
            DockPanelInGame.Visibility = Visibility.Visible;
        }
        #endregion

        #region Bank
        private void btnExitBank_Click(object sender, RoutedEventArgs e)
        {
            StackPanelBank.Visibility = Visibility.Hidden;
            DockPanelInGame.Visibility = Visibility.Visible;
        }
        #endregion

        private void btnGame_Any_Click(object sender, RoutedEventArgs e)
        {
            //wip
            //if not Already Build on this tile
            DockPanelBaumenu.Visibility = Visibility.Visible;
            DockPanelInGame.Visibility = Visibility.Hidden;
        }
        #region BauenMenu
        private void btnExitBaumenu_Click(object sender, RoutedEventArgs e)
        {
            DockPanelBaumenu.Visibility = Visibility.Hidden;
            DockPanelInGame.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
