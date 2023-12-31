﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekKalori.BLL.Services;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;
using System.Windows.Forms.DataVisualization.Charting;

namespace YemekKalori.UI.Properties
{
    public partial class FrmProfil : Form
    {
        public FrmProfil(Domain.Entities.User user)
        {
            InitializeComponent();

            this.user = user;
            userService = new UserService();
            mealService = new MealService();
            mealFoodService = new MealFoodService();
            foodService = new FoodService();

            VeriEkleOlustur();


        }

        UserService userService;
        MealService mealService;
        FoodService foodService;
        MealFoodService mealFoodService;
        Domain.Entities.User user;


        private void FrmProfil_Load(object sender, EventArgs e)
        {


            if (user != null)
            {

                var meals = mealService.GetMealByUser(user.Id);
                if (meals != null)
                {
                    var encoktuketilenMealFood = mealFoodService.GetTheMostConsumedMealFoodByMealId(meals.Id);
                    if (encoktuketilenMealFood != null)
                    {
                        var food = foodService.GetFoodById(encoktuketilenMealFood.FoodId);
                        lblEnCokTuketilenYiyecek.Text = $"{food.Name}";
                    }
                    else
                    {
                        lblEnCokTuketilenYiyecek.Text = " ";
                    }





                }
                else
                {
                    lblEnCokTuketilenYiyecek.Text = "liste boş";
                }


                lblBmi.Text = user.BMI.ToString();
                lblAdSoyad.Text = $"{user.FirstName} {user.LastName}";
                if (user.Goal==Domain.Enums.GoalType.GainWeight)
                {
                    txtBoxGoalType.Text = "Kilo almak";

                }
                else if(user.Goal == Domain.Enums.GoalType.LoseWeight)
                {
                    txtBoxGoalType.Text = "Kilo vermek";
                }
                txtBoxDietType.Text = user.Diet?.ToString();
                txtBoxBoy.Text = user.Height?.ToString();
                txtBoxKilo.Text = user.Weight?.ToString();
                lblHedefKcal.Text = user.HedefKalori.ToString();
                decimal? kalanKalori = user.HedefKalori - mealService.GetTodaysCalories(user.Id);
                if (kalanKalori < 0)
                {
                    lblKalanKcal.Text = "0";
                }
                else
                {
                    lblKalanKcal.Text = kalanKalori.ToString();
                }



            }
            else
            {
                MessageBox.Show("Kullanıcı bilgilerine ulaşılamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeriEkleOlustur()
        {

            this.Controls.Add(chartFavoriBesin);
            chartFavoriBesin.Titles.Add("Favori Besin İçeriği");

            if (user != null)
            {

                var meals = mealService.GetMealByUser(user.Id);
                if (meals != null)
                {
                    var encoktuketilenMealFood = mealFoodService.GetTheMostConsumedMealFoodByMealId(meals.Id);
                    if (encoktuketilenMealFood != null)
                    {
                        var food = foodService.GetFoodById(encoktuketilenMealFood.FoodId);
                        chartFavoriBesin.Series["Series1"].Points.AddXY("Karbonhidrat", food.CarbRate);
                        chartFavoriBesin.Series["Series1"].Points.AddXY("Yağ", food.FatRate);
                        chartFavoriBesin.Series["Series1"].Points.AddXY("Protein", food.ProteinRate);

                        chartFavoriBesin.Series["Series1"]["PieLabelStyle"] = "Disabled";

                    }



                }
            }
        }


        private void lnkLblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            PasswordChangeScreen passwordChangeScreen = new PasswordChangeScreen(user);
            passwordChangeScreen.ShowDialog();
            //this.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void lLabelGrafikler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Graph graph = new Graph(user);
            graph.ShowDialog();
        }
    }


}
