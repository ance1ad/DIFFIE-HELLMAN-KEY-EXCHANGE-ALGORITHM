using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using static _4lr.BigOperations;

namespace _4lr
{
    public partial class Form1 : Form
    {
        static int rootCount = 100;
        BigInteger[] arr = new BigInteger[rootCount];
        public Form1()
        {
            InitializeComponent();
        }
        private bool Carmichael(BigInteger big)
        {
            int[] carmichael = { 561, 1105, 1729, 2465, 2821, 6601, 8911, 10585, 15841, 29341, 41041, 46657, 52633, 62745, 63973, 75361 };
            for (int i = 0; i < carmichael.Length; i++)
            {
                if (big == carmichael[i])
                {
                    fermaViewTB.Text = "Число Кармайкла";
                    rabinViewTB.Text = "Число Кармайкла";
                    detViewTB.Text = "Число Кармайкла";
                    fermaTimeTB.Text = "";
                    rabinTimeTB.Text = "";
                    detTimeTB.Text = "";
                    return true;
                }
            }
            return false;
        }
        private bool TryParsingBigNum(string number, string author)
        {
            BigInteger big;
            if(number == "")
            {
                MessageBox.Show("Введена пустая строка! " + author,  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                BigInteger.TryParse(number, out big);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Введено не число! " + author, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (big < 10 && big > 0)
            {
                MessageBox.Show("Введено маленькое число" + author, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (big % 2 == 0)
            {
                MessageBox.Show("Введено четное число " + author, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool TryParsingRounds(string number, string type)
        {
            int rounds;
            try
            {
                Int32.TryParse(number, out rounds);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Введите целое число! ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rounds == 0)
            {
                MessageBox.Show("Введите не нулевое число " + type, " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private BigInteger SearchNum(BigInteger big)
        {
            bool flag = false;
            BigInteger result = 0;
            Random random = new Random();
            byte[] count = new byte[big.ToByteArray().LongLength];
            while (!flag)
            {
                random.NextBytes(count);
                result = new BigInteger(count);
                result = result > 0 ? result : -result;
                if (result >= 2 && result <= big - 2) flag = true;
            }
            return result;
        }

        private void FermaTest()
        {
            BigInteger big;
            BigInteger.TryParse(numberTB.Text, out big);


            Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();


            // Генерируем
            BigInteger revisor = 1; // подбор
            bool flag = true;
            revisor = SearchNum(big);
            BigInteger result = BigInteger.ModPow(revisor, big - 1, big);
            if (result == 1) { fermaViewTB.Text = "Простое"; }
            else fermaViewTB.Text = "Составное";
            stopWatch.Stop(); fermaTimeTB.Text = Convert.ToString(stopWatch.Elapsed);
        }
        private bool RabinMillerTest(BigInteger n)
        {

            int k; int.TryParse(roundsTB.Text, out k);
            Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            BigInteger d = n - 1;
            int s = 0;
            BigInteger a, x = 2;
            while (d % 2 == 0)
            {
                d /= 2; s++;
            }
            for (int i = 0; i < k; i++)
            {
                a = SearchNum(n);
                x = BigInteger.ModPow(a, n - 1, n);
                if (x == 1 || x == n - 1)
                {
                    continue;
                }

                bool flag = false;
                for (int j = 0; j < s && !flag; j++)
                {
                    x = x * x % n;
                    if (x == 1)
                    {
                        stopWatch.Stop(); rabinTimeTB.Text = Convert.ToString(stopWatch.Elapsed);
                        rabinViewTB.Text = "Составное";
                        return false;
                    }
                    if (x == n - 1) flag = true; // следующая итерация по K
                }
                if (x != n - 1)
                {
                    stopWatch.Stop(); rabinTimeTB.Text = Convert.ToString(stopWatch.Elapsed);
                    rabinViewTB.Text = "Составное";
                    return false;
                }
            }
            stopWatch.Stop(); rabinTimeTB.Text = Convert.ToString(stopWatch.Elapsed);
            rabinViewTB.Text = "Вероятно простое"; return true;
        }
        private void DivisibilityTheory()
        {
            BigInteger n;
            BigInteger.TryParse(numberTB.Text, out n);
            Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

            bool notFind = true;
            BigInteger sqrt = BigOperations.Sqrt(n);

            warning.Text = "Берем корень = " + sqrt.ToString();
            stopWatch.Start();
            for (int i = 3; i < sqrt; i++)
            {
                if (n % i == 0)
                {
                    detViewTB.Text = "Составное";
                    stopWatch.Stop(); detTimeTB.Text = Convert.ToString(stopWatch.Elapsed);
                    return;
                }
            }
            detViewTB.Text = "Простое"; return;
        }

        private BigInteger[] SerchRoots(BigInteger m)
        {
            BigInteger fm = m - 1;
            int counter = 0;
            BigInteger l = 1;
            Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            rootsText.Text = "";
            
            for (BigInteger a = 2; a < m && counter < rootCount; a++)
            {
                bool flag1 = true;
                l = 1;
                while (l < fm && flag1)
                {
                    if (BigInteger.ModPow(a, l, m) == 1)
                    {
                        flag1 = false;
                    }
                    l++;
                }
                if (flag1 && BigInteger.ModPow(a, fm, m) == 1)
                {
                    rootsText.Text += a.ToString() + " ";
                    arr[counter] = a;
                    counter++;
                }
            }
            stopWatch.Stop(); rootFindTime.Text = Convert.ToString(stopWatch.Elapsed);
            return arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cc2.Checked)
            {
                numberTB.Text = BinaryConvertToBigInteger(ccText.Text).ToString();

            }
            else if (cc16.Checked)
            {
                numberTB.Text = HexConvertToBigInteger(ccText.Text, 16).ToString();
            }
            else if ((!cc2.Checked || !cc16.Checked) && ccText.Text != "")
            {
                MessageBox.Show("Не выбрана система счисления! ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TryParsingBigNum(numberTB.Text, "p")) return;
            BigInteger big; BigInteger.TryParse(numberTB.Text, out big);
            big = big > 0 ? big : -big;
            numberTB.Text = big.ToString();

            if (!TryParsingRounds(roundsTB.Text, "раундов! ")) return;
            int rounds; Int32.TryParse(roundsTB.Text, out rounds);
            rounds = rounds > 0 ? rounds : -rounds;
            roundsTB.Text = rounds.ToString();


            if (Carmichael(big)) return;
            BigInteger n; BigInteger.TryParse(numberTB.Text, out n);

            FermaTest();
            RabinMillerTest(n);
            DivisibilityTheory();
            var arr = SerchRoots(BigInteger.Parse(numberTB.Text));

        }


        private bool Check2Pow(int pow)
        {
            for (int i = 2; i < 20; i++)
            {
                if ((int)Math.Pow(2, i) == pow)
                    return true;
            }
            return false;
        }




        private bool DivBySimple(BigInteger result)
        {
            int[] simpleN = { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499 };
            for (int i = 0; i < simpleN.Length; i++)
            {
                if (result % simpleN[i] == 0) return true;
            }
            return false;
        }


        private BigInteger GenerateSimpleNum()
        {
            if (!TryParsingRounds(roundsTB.Text, "раундов! ")) return 0;
            if (!TryParsingRounds(bytes.Text, "байт! ")) return 0 ;

            int bits; Int32.TryParse(bytes.Text, out bits);
            if (bits == 1)
            {
                MessageBox.Show("Введено маленькое число байт! ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            bits = bits > 0 ? bits : -bits;
            bytes.Text = bits.ToString();
            Random random = new Random();
            byte[] count = new byte[bits];

            BigInteger generate = 0;
            bool found = false;
            while (!found)
            {
                random.NextBytes(count);
                generate = new BigInteger(count);
                generate = generate > 0 ? generate : -generate;
                // Убрать четность и увеличить старший бит
                if (generate % 2 == 0) generate++;
                // Если кол-во байт степень 2
                if (Check2Pow(bits))
                    generate |= (1 << (bits * 8));
                else
                    generate |= (1 << (bits * 8) - 1);
                if (!DivBySimple(generate)) found = true;
                // Проверка миллера
                if (!RabinMillerTest(generate)) found = false;
                if (found)
                {
                    BigInteger q = (generate - 1) / 2;
                    if (!RabinMillerTest(q))
                        found = false;
                }
            }
            
            return generate;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            BigInteger generate = GenerateSimpleNum();
            numberTB.Text = generate.ToString();
            // Тут выводим также представленный вид числа
            if (cc2.Checked)
            {
                ccText.Text = ConvertToBinary(generate);
            }
            else if (cc16.Checked)
            {
                ccText.Text = generate.ToString("X");
            }

        }



        private void DiffieHellman()
        {
            BigInteger g = FindG();
            BigInteger p = BigInteger.Parse(numberTB.Text);
            gLabo.Visible = true;
            gLabo.Text = ("Генератор g = " + g.ToString());
            // Секретик
            BigInteger xa = BigInteger.Parse(aliceSecretTb.Text);
            BigInteger xb = BigInteger.Parse(bobSecretTb.Text);
            // Известно 
            BigInteger ya = BigInteger.ModPow(g, xa, p);
            BigInteger yb = BigInteger.ModPow(g, xb, p);
            // Ключ (должны быть равны)
            BigInteger k1 = BigInteger.ModPow(yb, xa, p);
            BigInteger k2 = BigInteger.ModPow(ya, xb, p);
            // Заполняем
            aliceGeneralTb.Text = ya.ToString();
            bobGeneralTb.Text = yb.ToString();
            secretKey1.Text = k1.ToString();
            secretKey2.Text = k2.ToString();

        }

        private BigInteger FindG()
        {
            BigInteger g = new BigInteger(1);
            BigInteger p = BigInteger.Parse(numberTB.Text);
            for (int i = 25; i < rootCount; i++)
            {
                if (BigInteger.ModPow(arr[i], p, p) != 1)
                {
                    return arr[i];
                }
            }
            return 0;
        }

        private void diffieHellmanBtn_Click(object sender, EventArgs e)
        {
            DiffieHellman();
            if (!TryParsingBigNum(aliceSecretTb.Text, "у Алисы")) return;
            if (!TryParsingBigNum(bobSecretTb.Text, "у Боба")) return;
            if (!TryParsingRounds(roundsTB.Text, "раундов! ")) return;
            if (!RabinMillerTest(BigInteger.Parse(aliceSecretTb.Text)))
            {
                MessageBox.Show("Введено составное число у Алисы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!RabinMillerTest(BigInteger.Parse(bobSecretTb.Text)))
            {
                MessageBox.Show("Введено составное число у Боба", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void bob_Click(object sender, EventArgs e)
        {
            BigInteger bobPrivateNum = GenerateSimpleNum();
            bobSecretTb.Text = bobPrivateNum.ToString();
        }

        private void Alice_Click(object sender, EventArgs e)
        {
            BigInteger alicePrivateNum = GenerateSimpleNum();
            aliceSecretTb.Text = alicePrivateNum.ToString();

        }
    }
}