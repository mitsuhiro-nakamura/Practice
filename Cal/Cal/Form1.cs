using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/************************************
 *      アーベルソフト　内定者研修１
 *      ソフト：電卓
 *      作者　：中央高等技術専門校
 *            　谷島　侑樹
 *      開発日：2014年7月30日～
 *                    7月31日
 ************************************/

namespace Cal
{
    public partial class Form1 : Form
    {

        //  変数の定義

        double[] sum = new double[2];               //  演算対象の値
        double[] sumBack = new double[2];           //  sumの値をバックアップ
        double[] sumFullBack = new double[15];      //  sumの値を入力毎バックアップ
        double smallNumberLevel = 1;                //  少数の位置の計算
        double ans = 0;                             //  演算結果
        sbyte sumflug = 0;                          //  sumの配列値
        sbyte ope;                                  //  演算子の番号
        sbyte smallZero = 0;                        //  小数点以下0の数 (0以外を入力すると、初期化)
        byte smallNumberPlace = 0;                  //  小数の位置
        bool ansFlug = false;                       //  演算結果を表示するフラグ(=を使う場面)
        bool ansDispFlug = false;                   //  演算結果を表示するフラグ(=を使わない場面)
        bool ansOneClickFlug = false;               //  演算結果を表示するフラグ(√など、ワンクリックで答えが表示される場面)
        bool calButtonClickFlug = false;            //  数字ボタンを押しているフラグ
        bool icolTrace = false;                     //  =を押した痕跡を記憶する
        bool divisionErrorFlug = false;             //  0で割った場合に表示するエラー
        bool continueOpeFlug = false;               //  =を押した後、演算子を入力しているフラグ
        bool smallNumberFlug = false;               //  少数フラグ(.を使う)

        //  関数

        #region フォーム関数

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
        }

        #endregion

        //  タイマーを使ったリアルタイム処理

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!ansFlug)
            {
                answer.Text = sum[sumflug].ToString();
            }
            else
            {
                answer.Text = ans.ToString();
            }
            if (ansOneClickFlug)
            {
                answer.Text = ans.ToString();
            }
            if (divisionErrorFlug)
            {
                answer.Text = "0 で割れません！";
            }
            if (ansDispFlug == true)
            {
                if (!divisionErrorFlug)
                {

                    answer.Text = sum[0].ToString();
                }
                else
                {
                    answer.Text = "0 で割れません！";
                }
            }
            if (ope == 0)
                opeLabel.Text = null;
            if (ope == 1)
                opeLabel.Text = "＋";
            if (ope == 2)
                opeLabel.Text = "－";
            if (ope == 3)
                opeLabel.Text = "×";
            if (ope == 4)
                opeLabel.Text = "÷";
            if (ope == 5)
                opeLabel.Text = "√";
            if (ope == 6)
                opeLabel.Text = "％";
            if (ope == 7)
                opeLabel.Text = "1/x";

            if (smallZero > 0)
                smallZeroLabel.Text = smallZero.ToString();
            else
                smallZeroLabel.Text = null;
            label1.Text = "ope = " + ope + " | ans = " + ans;
            label2.Text = "Place = " + smallNumberPlace + " | Level = " + smallNumberLevel;
            System.Console.WriteLine("sum 0 = " + sum[0] + " sum 1 = " + sum[1] + " sumflug = " + sumflug+" cnt = "+continueOpeFlug+" ope = "+ope+
                " cBt = "+calButtonClickFlug);
        }

        #region 数字ボタン

        private void cal0_Click(object sender, EventArgs e)
        {

            //  =が押されていてかつ、連続計算がオフのとき、オールクリアする

            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }

            //  =が押されている場合、右辺の値を初期化する

            if (icolTrace)
            {
                sum[1] = 0;
            }

            //  ワンクリック演算の答えが表示されている場合、オールクリアする

            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }

            //  整数の入力をする

            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 0;

            //  少数の入力をする

            else
            {
                sum[sumflug] = sum[sumflug] + 0 / SmallNumberOperation();
                smallZero++;
            }
            sumFullBack[smallNumberPlace] = sum[sumflug];   //  入力毎に値をバックアップする。Back機能で使う。
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal1_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 1;
            else
                sum[sumflug] = sum[sumflug] + 1 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal2_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 2;
            else
                sum[sumflug] = sum[sumflug] + 2 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal3_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 3;
            else
                sum[sumflug] = sum[sumflug] + 3 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal4_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 4;
            else
                sum[sumflug] = sum[sumflug] + 4 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal5_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 5;
            else
                sum[sumflug] = sum[sumflug] + 5 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal6_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 6;
            else
                sum[sumflug] = sum[sumflug] + 6 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal7_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 7;
            else
                sum[sumflug] = sum[sumflug] + 7 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal8_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 8;
            else
                sum[sumflug] = sum[sumflug] + 8 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        private void cal9_Click(object sender, EventArgs e)
        {
            if (icolTrace && !continueOpeFlug)
            {
                SumClear();
            }
            if (icolTrace)
            {
                sum[1] = 0;
            }
            if (ansOneClickFlug)
            {
                sum[1] = 0;
                sumflug = 1;
                ansOneClickFlug = false;
            }
            if (!smallNumberFlug)
                sum[sumflug] = sum[sumflug] * 10 + 9;
            else
                sum[sumflug] = sum[sumflug] + 9 / SmallNumberOperation();
            sumFullBack[smallNumberPlace] = sum[sumflug];
            if (smallNumberPlace < 14)
                smallNumberPlace++;
            smallZero = 0;
            sumBack[1] = 0;
            ansDispFlug = false;
            ansFlug = false;
            calButtonClickFlug = true;
            icolTrace = false;
        }

        #endregion

        #region 演算子ボタン 1=+ , 2=- , 3=* , 4=/ , 5=√

        private void plus_Click(object sender, EventArgs e)
        {
            Operation();
            sumBack[1] = sum[0];
            sum[1] = 0;

            //  数字が入力されてない場合、右辺に左辺の値を代入(連続計算を可能にする為)

            if (!calButtonClickFlug)
                sum[1] = sum[0];
            ansDispFlug = true;
            sumBack[0] = sum[0];
            ope = 1;
            sumflug = 1;
            if (icolTrace)
            {
                sum[1] = sum[0];
                continueOpeFlug = true;
            }
            if (!calButtonClickFlug)
                sum[1] = 0;
            if (!icolTrace)
                calButtonClickFlug = false;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Operation();
            sumBack[1] = sum[0];
            sum[1] = 0;
            if (!calButtonClickFlug)
                sum[1] = sum[0];
            ansDispFlug = true;
            sumBack[0] = sum[0];
            ope = 2;
            sumflug = 1;
            if (icolTrace)
            {
                sum[1] = sum[0];
                continueOpeFlug = true;
            }
            if (!calButtonClickFlug)
                sum[1] = 0;
            if (!icolTrace)
                calButtonClickFlug = false;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            Operation();
            sumBack[1] = sum[0];
            sum[1] = 0;
            if (!calButtonClickFlug)
                sum[1] = sum[0];
            ansDispFlug = true;
            sumBack[0] = sum[0];
            ope = 3;
            sumflug = 1;
            if (icolTrace)
            {
                sum[1] = sum[0];
                continueOpeFlug = true;
            }
            if (!calButtonClickFlug)
                sum[1] = 0;
            if (!icolTrace)
                calButtonClickFlug = false;
        }

        private void division_Click(object sender, EventArgs e)
        {
            Operation();
            sumBack[1] = sum[0];
            sum[1] = 0;
            if (!calButtonClickFlug)
                sum[1] = sum[0];
            ansDispFlug = true;
            sumBack[0] = sum[0];
            ope = 4;
            sumflug = 1;
            if (icolTrace)
            {
                sum[1] = sum[0];
                continueOpeFlug = true;
            }
            if (!calButtonClickFlug)
                sum[1] = 0;
            if (!icolTrace)
                calButtonClickFlug = false;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            ans = Math.Sqrt(sum[0]-sum[1]);
            sum[0] = ans;
            ansOneClickFlug = true;
            ope = 5;
        }

        private void not_Click(object sender, EventArgs e)
        {
            if (sum[1] != 0)
            {
                sum[1] = sum[1] / 100;
                ans = sum[0] / sum[1];
            }
            else
            {
                ans = sum[0] / 100;
                sum[0] = ans;
            }
            ansOneClickFlug = true;
            ope = 6;
        }

        private void fraction_Click(object sender, EventArgs e)
        {
            Operation();
            if (sum[0] != 0)
                ans = 1 / sum[0];
            else
                divisionErrorFlug = true;
            sum[0] = ans;
            ansOneClickFlug = true;
            ope = 7;
        }

        #endregion

        //  =を押したときの処理

        private void icol_Click(object sender, EventArgs e)
        {
            switch (ope)
            {
                case 1:
                    ans = sum[0] + sum[1];
                    if (!calButtonClickFlug)
                        ans = sum[0] + sumBack[1];
                    break;
                case 2:
                    ans = sum[0] - sum[1];
                    if (!calButtonClickFlug)
                        ans = sum[0] - sumBack[1];
                    break;
                case 3:
                    ans = sum[0] * sum[1];
                    if (!calButtonClickFlug)
                        ans = sum[0] * sumBack[1];
                    break;
                case 4:
                    if (sum[1] != 0)
                        ans = sum[0] / sum[1];
                    else
                    {
                        if (!calButtonClickFlug)
                            ans = sum[0] / sumBack[1];
                        else
                            divisionErrorFlug = true;
                    }
                    break;
            }
            ansFlug = true;
            sum[0] = ans;
            smallNumberPlace = 0;
            //sum[1] = 0;
            icolTrace = true;
        }

        //  =を使わない連続演算時の処理

        void Operation()
        {
            //  少数のクリア

            smallNumberPlace = 0;
            smallNumberLevel = 1;
            smallNumberFlug = false;

            //  数字を入力した状態かつ、=が押されていない状態の場合、左辺に、演算結果を代入する

            if (calButtonClickFlug && !icolTrace)
            {
                switch (ope)
                {
                    case 1:
                        sum[0] = sum[0] + sum[1];
                        break;
                    case 2:
                        sum[0] = sum[0] - sum[1];
                        break;
                    case 3:
                        sum[0] = sum[0] * sum[1];
                        break;
                    case 4:
                        if (sum[1] != 0)
                        {
                            sum[0] = sum[0] / sum[1];
                        }
                        else
                        {
                            divisionErrorFlug = true;
                        }
                        break;
                   
                }
            }
        }

        //  少数の桁数を求める

        double SmallNumberOperation()
        {
            return smallNumberLevel *= 10;
        }

        //  オールクリア

        void SumClear()
        {
            sum[0] = 0;
            sum[1] = 0;
            ans = 0;
            sumflug = 0;
            ope = 0;
            ansFlug = false;
            ansDispFlug = false;
            ansOneClickFlug = false;
            calButtonClickFlug = false;
            icolTrace = false;
            divisionErrorFlug = false;
            smallNumberFlug = false;
            smallNumberLevel = 1;
            smallNumberPlace = 0;
            smallZero = 0;
        }

        //  少数ボタンをクリック

        private void syosu_Click(object sender, EventArgs e)
        {
            smallNumberFlug = true;
        }

        //  Cをクリック

        private void Clear_Click(object sender, EventArgs e)
        {
            SumClear();
        }

        //  CEをクリック

        private void ClearEnd_Click(object sender, EventArgs e)
        {
            if (!icolTrace)
            {
                if (sumflug == 1)
                {
                    sum[1] = 0;
                }
                else
                {
                    sum[0] = 0;
                    sumflug = 0;
                }
            }
            else
            {
                sum[0] = sumBack[0];
                sum[1] = 0;
                icolTrace = false;
                ansFlug = false;
            }
            smallZero = 0;
            smallNumberPlace = 0;
        }

        //  Backをクリック

        private void Back_Click(object sender, EventArgs e)
        {

            //  各桁の値を左辺または右辺に代入

            if (smallNumberPlace < 15)
            {
                if (smallNumberPlace > 1)
                {
                    smallNumberPlace--;
                    sum[sumflug] = sumFullBack[smallNumberPlace - 1];
                }
                else
                {
                    sum[sumflug] = 0;
                    smallNumberPlace = 0;
                }
            }
            smallZero = 0;
        }

        //  +/-をクリック

        private void plusOrMinus_Click(object sender, EventArgs e)
        {
            sum[sumflug] = sum[sumflug] - (sum[sumflug] * 2);
        }
    }
}
