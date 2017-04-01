using Android.App;
using Android.Widget;
using Android.OS;

namespace Aplicacion1VS
{
    [Activity(Label = "Aplicacion1VS", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        #region Declarar Botones
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        Button btn9;
        #endregion

        protected byte[,] Matriz = new byte[,] { { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };
        int contador = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            #region Inicializar Botones
            btn1 = FindViewById<Button>(Resource.Id.button1);
            btn2 = FindViewById<Button>(Resource.Id.button2);
            btn3 = FindViewById<Button>(Resource.Id.button3);
            btn4 = FindViewById<Button>(Resource.Id.button4);
            btn5 = FindViewById<Button>(Resource.Id.button5);
            btn6 = FindViewById<Button>(Resource.Id.button6);
            btn7 = FindViewById<Button>(Resource.Id.button7);
            btn8 = FindViewById<Button>(Resource.Id.button8);
            btn9 = FindViewById<Button>(Resource.Id.button9);

            #endregion

            #region EventosClick
            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
            btn6.Click += Btn6_Click;
            btn7.Click += Btn7_Click;
            btn8.Click += Btn8_Click;
            btn9.Click += Btn9_Click;

#endregion



        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn9.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[2, 2] = 1;
            }
            else
            {
                btn9.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[2, 2] = 2;
            }
            contador++;
            btn9.Enabled = false;

        }

        private void Btn8_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn8.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[2, 1] = 1;
            }
            else
            {
                btn8.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[2, 1] = 2;
            }
            contador++;
            btn8.Enabled = false;

        }

        private void Btn7_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn7.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[2, 0] = 1;
            }
            else
            {
                btn7.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[2, 0] = 2;
            }
            contador++;
            btn7.Enabled = false;
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn6.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[1, 2] = 1;
            }
            else
            {
                btn6.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[1, 2] = 2;
            }
            contador++;
            btn6.Enabled = false;

        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn5.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[1, 1] = 1;
            }
            else
            {
                btn5.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[1, 1] = 2;
            }
            contador++;
            btn5.Enabled = false;
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn4.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[1, 0] = 1;
            }
            else
            {
                btn4.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[1, 0] = 2;
            }
            contador++;
            btn4.Enabled = false;
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn3.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[0, 2] = 1;
            }
            else
            {
                btn3.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[0, 2] = 2;
            }
            contador++;
            btn3.Enabled = false;
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            if (contador % 2 == 0)
            {
                btn2.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[0, 1] = 1;
            }
            else
            {
                btn2.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[0, 1] = 2;
            }
            contador++;
            btn2.Enabled = false;
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            if (contador%2==0)
            {
                btn1.SetBackgroundResource(Resource.Drawable.circle);
                Matriz[0, 0] = 1;
            }
            else
            {
                btn1.SetBackgroundResource(Resource.Drawable.cross);
                Matriz[0, 0] = 2;
            }
            contador++;
            btn1.Enabled = false;  
        }
    }
}

