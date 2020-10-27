using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Kaomoji_Picker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void pinned_button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Topmost != true)
            {
                this.Topmost = true;
                pinned_button.Content = "\xE77A";
            }
            else
            {
                this.Topmost = false;
                pinned_button.Content = "\xE718";
            }
        }

        private void minimize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void close_button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Window.GetWindow(this).Close();
        }

        private void KaoBtn_Click(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;
            Clipboard.SetText(tag.ToString());
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            kaoViewer.ScrollToTop();
            var menuButton = ((Button)sender).Tag;
            int menuTag = Convert.ToInt32(menuButton);

            if (menuTag == 0)
            {
                kaoBtn1.Content = kaoBtn1.Tag = "('∀｀）";
                kaoBtn2.Content = kaoBtn2.Tag = "（＾∀＾）";
                kaoBtn3.Content = kaoBtn3.Tag = "(｀▽')";
                kaoBtn4.Content = kaoBtn4.Tag = "('w｀*)";
                kaoBtn5.Content = kaoBtn5.Tag = "(*'∇｀*)";
                kaoBtn6.Content = kaoBtn6.Tag = "（●＞ω＜●）";
                kaoBtn7.Content = kaoBtn7.Tag = "(≧∀≦ゞ";
                kaoBtn8.Content = kaoBtn8.Tag = "(≧∇≦)b";
                kaoBtn9.Content = kaoBtn9.Tag = "(°∀°)ゝ'";
                kaoBtn10.Content = kaoBtn10.Tag = "(=ﾟ▽ﾟ)/";
                kaoBtn11.Content = kaoBtn11.Tag = "(＞Д＜)ゝ'";
                kaoBtn12.Content = kaoBtn12.Tag = "(ｏ'ｖ｀ｂ)ｂ";
                kaoBtn13.Content = kaoBtn13.Tag = "(　'∀｀)b";
                kaoBtn14.Content = kaoBtn14.Tag = "(o^-')b";
                kaoBtn15.Content = kaoBtn15.Tag = "ヾ(＾∇＾)";
                kaoBtn16.Content = kaoBtn16.Tag = "(≧∇≦)/";
                kaoBtn17.Content = kaoBtn17.Tag = "(。･∀･)ﾉ";
                kaoBtn18.Content = kaoBtn18.Tag = "( ﾟ▽ﾟ)/";
                kaoBtn19.Content = kaoBtn19.Tag = "ヾ(・ω・ｏ)";
                kaoBtn20.Content = kaoBtn20.Tag = "ヾ('￢｀)ﾉ";
                kaoBtn21.Content = kaoBtn21.Tag = "(खਉख)";
                kaoBtn22.Content = kaoBtn22.Tag = "(ಡ艸ಡ)";
                kaoBtn23.Content = kaoBtn23.Tag = "（＞ｙ＜）";
                kaoBtn24.Content = kaoBtn24.Tag = "(Ŏ艸Ŏ)";
                kaoBtn25.Content = kaoBtn25.Tag = "(^ц^ )";
                kaoBtn26.Content = kaoBtn26.Tag = "（　'∀｀）";
                kaoBtn27.Content = kaoBtn27.Tag = "（≧ｙ≦＊）";
                kaoBtn28.Content = kaoBtn28.Tag = "(*'∀｀）";
                kaoBtn29.Content = kaoBtn29.Tag = "（'υ｀）";
                kaoBtn30.Content = kaoBtn30.Tag = "(･∀･)";
                kaoBtn31.Content = kaoBtn31.Tag = "('ｖ｀)";
                kaoBtn32.Content = kaoBtn32.Tag = "(・∀・｀；)";
                kaoBtn33.Content = kaoBtn33.Tag = "(･ω･)v";
                kaoBtn34.Content = kaoBtn34.Tag = "(*ゝ∀･)v";
                kaoBtn35.Content = kaoBtn35.Tag = "(●≧ω≦)9";
                kaoBtn36.Content = kaoBtn36.Tag = "ヽ(ﾟ∀｡)ﾉ";
                kaoBtn37.Content = kaoBtn37.Tag = "＼\\\\٩( 'ω' )و //／";
                kaoBtn38.Content = kaoBtn38.Tag = "⊙▽⊙";
                kaoBtn39.Content = kaoBtn39.Tag = "（＾ｖ＾）";
                kaoBtn40.Content = kaoBtn40.Tag = "〔'∇｀〕";
                kaoBtn41.Content = kaoBtn41.Tag = "(＾ω＾)";
                kaoBtn42.Content = kaoBtn42.Tag = "ヽ(ヅ)ノ";
                kaoBtn43.Content = kaoBtn43.Tag = "(ᗒᗨᗕ)";
                kaoBtn44.Content = kaoBtn44.Tag = "≧ω≦";
                kaoBtn45.Content = kaoBtn45.Tag = "(⊙ᗜ⊙)";
                kaoBtn46.Content = kaoBtn46.Tag = "୧⍢⃝୨";
                kaoBtn47.Content = kaoBtn47.Tag = "(≧∇≦*)";
                kaoBtn48.Content = kaoBtn48.Tag = "ヽ(＾Д＾)ﾉ";
                kaoBtn49.Content = kaoBtn49.Tag = "ƪ(•◡•ƪ)\"ょぃょぃ";
                kaoBtn50.Content = kaoBtn50.Tag = "いくぞ!٩(ˊᗜˋ*) و";
                kaoBtn51.Content = kaoBtn51.Tag = "₍₍ (ง ˘ω˘ )ว ⁾⁾　ｽﾔｯ ｽﾔｯ";
                kaoBtn52.Content = kaoBtn52.Tag = "ヾ(〃l _ l)ﾉﾞ";
                kaoBtn53.Content = kaoBtn53.Tag = "⁽⁽◝( ˙ ꒳ ˙ )◜⁾⁾";
                kaoBtn54.Content = kaoBtn54.Tag = "₍₍ ◝( ´ω´ )◟ ⁾⁾";
                kaoBtn55.Content = kaoBtn55.Tag = "(ර⍵ර)✧";
                kaoBtn56.Content = kaoBtn56.Tag = "◞( ､*´▿`)､";
                kaoBtn57.Content = kaoBtn57.Tag = "꒰ ∩´∇ `∩꒱";
                kaoBtn58.Content = kaoBtn58.Tag = "(੭•̀ᴗ•̀)੭";
                kaoBtn59.Content = kaoBtn59.Tag = "ɷ◡ɷ";
                kaoBtn60.Content = kaoBtn60.Tag = "（ꉺᗜꉺ）";

            }
            else if (menuTag == 1)
            {
                kaoBtn1.Content = kaoBtn1.Tag = "(-、-)";
                kaoBtn2.Content = kaoBtn2.Tag = "('Å｀)";
                kaoBtn3.Content = kaoBtn3.Tag = "(ﾟヘﾟ)";
                kaoBtn4.Content = kaoBtn4.Tag = "(∵）";
                kaoBtn5.Content = kaoBtn5.Tag = "（・―・）";
                kaoBtn6.Content = kaoBtn6.Tag = "（｀ー'）";
                kaoBtn7.Content = kaoBtn7.Tag = "( 'ｰ`)";
                kaoBtn8.Content = kaoBtn8.Tag = "(;'д｀)";
                kaoBtn9.Content = kaoBtn9.Tag = "('ﾟзﾟ)";
                kaoBtn10.Content = kaoBtn10.Tag = "（＞μ＜＃）";
                kaoBtn11.Content = kaoBtn11.Tag = "(・ε・｀*)";
                kaoBtn12.Content = kaoBtn12.Tag = "(ó﹏ò｡)";
                kaoBtn13.Content = kaoBtn13.Tag = "('･д･｀)";
                kaoBtn14.Content = kaoBtn14.Tag = "…φ(。。*)";
                kaoBtn15.Content = kaoBtn15.Tag = "ಠ_ಠ";
                kaoBtn16.Content = kaoBtn16.Tag = "(｀Д')";
                kaoBtn17.Content = kaoBtn17.Tag = "(`A')";
                kaoBtn18.Content = kaoBtn18.Tag = "-`д'-";
                kaoBtn19.Content = kaoBtn19.Tag = "(ಠ ∩ಠ)";
                kaoBtn20.Content = kaoBtn20.Tag = "╥﹏╥";
                kaoBtn21.Content = kaoBtn21.Tag = "(ㄒoㄒ)";
                kaoBtn22.Content = kaoBtn22.Tag = "(Ｔ▽Ｔ)";
                kaoBtn23.Content = kaoBtn23.Tag = "（ｉДｉ）";
                kaoBtn24.Content = kaoBtn24.Tag = "（'＿｀）";
                kaoBtn25.Content = kaoBtn25.Tag = "(T⌓T)";
                kaoBtn26.Content = kaoBtn26.Tag = "(ノ﹏ヽ)";
                kaoBtn27.Content = kaoBtn27.Tag = "（πーπ）";
                kaoBtn28.Content = kaoBtn28.Tag = "(つ﹏<。)";
                kaoBtn29.Content = kaoBtn29.Tag = "('Д⊂";
                kaoBtn30.Content = kaoBtn30.Tag = "('д｀)";
                kaoBtn31.Content = kaoBtn31.Tag = "つ'Д`)つ";
                kaoBtn32.Content = kaoBtn32.Tag = "（ノд｀＠）";
                kaoBtn33.Content = kaoBtn33.Tag = "(;'д｀)";
                kaoBtn34.Content = kaoBtn34.Tag = "o(；△；)o";
                kaoBtn35.Content = kaoBtn35.Tag = "('；ω；｀)";
                kaoBtn36.Content = kaoBtn36.Tag = "ヽ('Д`;)ﾉ";
                kaoBtn37.Content = kaoBtn37.Tag = "（◞‸◟）";
                kaoBtn38.Content = kaoBtn38.Tag = "(*'Д｀)=з";
                kaoBtn39.Content = kaoBtn39.Tag = "(つд⊂)";
                kaoBtn40.Content = kaoBtn40.Tag = "(ノAヽ)";
                kaoBtn41.Content = kaoBtn41.Tag = "( ,,-` ｡´-)ﾎｫｰ";
                kaoBtn42.Content = kaoBtn42.Tag = "(;´༎ຶٹ༎ຶ`)";
                kaoBtn43.Content = kaoBtn43.Tag = "꒰ ∩ ´ Д`;꒱";
                kaoBtn44.Content = kaoBtn44.Tag = "༼ಢ_ಢ༽";
                kaoBtn45.Content = kaoBtn45.Tag = "(இ﹏இ`｡)";
                kaoBtn46.Content = kaoBtn46.Tag = "༼ ༎ຶ ෴ ༎ຶ༽";
                kaoBtn47.Content = kaoBtn47.Tag = "(┳Д┳)";
                kaoBtn48.Content = kaoBtn48.Tag = "Σ(￣ロ￣lll)";
                kaoBtn49.Content = kaoBtn49.Tag = "（（（(T-T*)）））";
                kaoBtn50.Content = kaoBtn50.Tag = "＿ﾉ乙(､ﾝ､)＿";
                kaoBtn51.Content = kaoBtn51.Tag = "(_　_|||)";
                kaoBtn52.Content = kaoBtn52.Tag = "ヽ(冫、)ﾉ";
                kaoBtn53.Content = kaoBtn53.Tag = "(◔ д◔)";
                kaoBtn54.Content = kaoBtn54.Tag = "(ʘдʘ╬)";
                kaoBtn55.Content = kaoBtn55.Tag = "ლಠ益ಠ)ლ";
                kaoBtn56.Content = kaoBtn56.Tag = "( 'ｰ`)";
                kaoBtn57.Content = kaoBtn57.Tag = "…ρ(･ω`･､)";
                kaoBtn58.Content = kaoBtn58.Tag = "(｀へ′)";
                kaoBtn59.Content = kaoBtn59.Tag = "ꉂ `o´  )";
                kaoBtn60.Content = kaoBtn60.Tag = "(。ヘ°)";
            }
            else if (menuTag == 2)
            {
                kaoBtn1.Content = kaoBtn1.Tag = "(✿ヘᴥヘ)";
                kaoBtn2.Content = kaoBtn2.Tag = "(✿╹◡╹)";
                kaoBtn3.Content = kaoBtn3.Tag = "(人◕ω◕)";
                kaoBtn4.Content = kaoBtn4.Tag = "(ㆁᴗㆁ✿)";
                kaoBtn5.Content = kaoBtn5.Tag = "(ﾉ≧ڡ≦)";
                kaoBtn6.Content = kaoBtn6.Tag = "(*бωб)";
                kaoBtn7.Content = kaoBtn7.Tag = "(〃‿〃✿)";
                kaoBtn8.Content = kaoBtn8.Tag = "❀◕ ‿ ◕❀";
                kaoBtn9.Content = kaoBtn9.Tag = "✾◕ ‿ ◕✾";
                kaoBtn10.Content = kaoBtn10.Tag = "(๑ゝڡ◕๑)";
                kaoBtn11.Content = kaoBtn11.Tag = "(・ωｰ)～☆";
                kaoBtn12.Content = kaoBtn12.Tag = "('ω｀*)";
                kaoBtn13.Content = kaoBtn13.Tag = "(ﾉ∀`♥)";
                kaoBtn14.Content = kaoBtn14.Tag = "(*≧∀≦*)";
                kaoBtn15.Content = kaoBtn15.Tag = "(*'台｀*)";
                kaoBtn16.Content = kaoBtn16.Tag = "v(^∀^*)";
                kaoBtn17.Content = kaoBtn17.Tag = "(*'ω｀*)";
                kaoBtn18.Content = kaoBtn18.Tag = "(〃▽〃)";
                kaoBtn19.Content = kaoBtn19.Tag = "(ノ▽〃)";
                kaoBtn20.Content = kaoBtn20.Tag = "(〃ー〃)";
                kaoBtn21.Content = kaoBtn21.Tag = "(〃ω〃)";
                kaoBtn22.Content = kaoBtn22.Tag = "('つヮ⊂)";
                kaoBtn23.Content = kaoBtn23.Tag = "(♡'艸`)";
                kaoBtn24.Content = kaoBtn24.Tag = "(／≧ω＼)";
                kaoBtn25.Content = kaoBtn25.Tag = "(/へ＼*)";
                kaoBtn26.Content = kaoBtn26.Tag = "(*ﾉωﾉ)";
                kaoBtn27.Content = kaoBtn27.Tag = "(ﾉ∇≦*)";
                kaoBtn28.Content = kaoBtn28.Tag = "(〃'∀｀)";
                kaoBtn29.Content = kaoBtn29.Tag = "(〃∀〃)ゞ";
                kaoBtn30.Content = kaoBtn30.Tag = "( 〃．．)";
                kaoBtn31.Content = kaoBtn31.Tag = "ღゝ◡╹)ノ♡";
                kaoBtn32.Content = kaoBtn32.Tag = "ヽ(o♡o)/";
                kaoBtn33.Content = kaoBtn33.Tag = "(灬♥ω♥灬)";
                kaoBtn34.Content = kaoBtn34.Tag = "（'・｀ ）♡";
                kaoBtn35.Content = kaoBtn35.Tag = "(⺣◡⺣)♡*";
                kaoBtn36.Content = kaoBtn36.Tag = "♡(ŐωŐ人)";
                kaoBtn37.Content = kaoBtn37.Tag = "⊂（♡⌂♡）⊃";
                kaoBtn38.Content = kaoBtn38.Tag = "♡ඩ⌔ඩ♡";
                kaoBtn39.Content = kaoBtn39.Tag = "♱♡‿♡♰";
                kaoBtn40.Content = kaoBtn40.Tag = "♡(ŐωŐ人)";
                kaoBtn41.Content = kaoBtn41.Tag = "( ˘ ³˘)";
                kaoBtn42.Content = kaoBtn42.Tag = "(~￣³￣)~";
                kaoBtn43.Content = kaoBtn43.Tag = "ლ(・ヮ・ლ)";
                kaoBtn44.Content = kaoBtn44.Tag = "⊂(・ヮ・⊂)";
                kaoBtn45.Content = kaoBtn45.Tag = "(っ'▽｀)っ";
                kaoBtn46.Content = kaoBtn46.Tag = "(っ*'∀｀*)っ";
                kaoBtn47.Content = kaoBtn47.Tag = "(.づσ▿σ)づ.";
                kaoBtn48.Content = kaoBtn48.Tag = "( ☌ω☌)ｼﾞｨｰ♥";
                kaoBtn49.Content = kaoBtn49.Tag = "ღ❤ღ´ｪ`*)";
                kaoBtn50.Content = kaoBtn50.Tag = "(ღ˘⌣˘ღ)";
                kaoBtn51.Content = kaoBtn51.Tag = "(๑♡3♡๑)";
                kaoBtn52.Content = kaoBtn52.Tag = "(♡'艸`)";
                kaoBtn53.Content = kaoBtn53.Tag = "✿♥‿♥✿";
                kaoBtn54.Content = kaoBtn54.Tag = "(♥ω♥*)";
                kaoBtn55.Content = kaoBtn55.Tag = "(*ゝω・)ﾉ";
                kaoBtn56.Content = kaoBtn56.Tag = "(๑ゝڡ◕๑)";
                kaoBtn57.Content = kaoBtn57.Tag = "(๑◕ㅂ▰)";
                kaoBtn58.Content = kaoBtn58.Tag = "(*＾∀ﾟ)ъ";
                kaoBtn59.Content = kaoBtn59.Tag = "(・ω<)";
                kaoBtn60.Content = kaoBtn60.Tag = "(◕ᴗ◕✿)";
            }
            else if (menuTag == 3)
            {
                kaoBtn1.Content = kaoBtn1.Tag = "⚆ᗝ⚆";
                kaoBtn2.Content = kaoBtn2.Tag = "ଵ˛̼ଵ";
                kaoBtn3.Content = kaoBtn3.Tag = "˚▱˚";
                kaoBtn4.Content = kaoBtn4.Tag = "（／．＼）";
                kaoBtn5.Content = kaoBtn5.Tag = "（/｡＼)";
                kaoBtn6.Content = kaoBtn6.Tag = "(ﾟдﾟ)";
                kaoBtn7.Content = kaoBtn7.Tag = "(O∆O)";
                kaoBtn8.Content = kaoBtn8.Tag = "ゞ◎Д◎ヾ";
                kaoBtn9.Content = kaoBtn9.Tag = "（ΩДΩ）";
                kaoBtn10.Content = kaoBtn10.Tag = "《ﾟДﾟ》";
                kaoBtn11.Content = kaoBtn11.Tag = "ミ●﹏☉ミ";
                kaoBtn12.Content = kaoBtn12.Tag = "(ノдヽ)";
                kaoBtn13.Content = kaoBtn13.Tag = "(꒪⌓꒪)";
                kaoBtn14.Content = kaoBtn14.Tag = "ゞ◎Д◎ヾ";
                kaoBtn15.Content = kaoBtn15.Tag = "(⊃д⊂)";
                kaoBtn16.Content = kaoBtn16.Tag = "(ノдヽ)";
                kaoBtn17.Content = kaoBtn17.Tag = "(゜Д゜*)";
                kaoBtn18.Content = kaoBtn18.Tag = "ヽ(ﾟДﾟ)ﾉ";
                kaoBtn19.Content = kaoBtn19.Tag = "༼⁰o⁰；༽";
                kaoBtn20.Content = kaoBtn20.Tag = "(°o°:)";
                kaoBtn21.Content = kaoBtn21.Tag = "(＞△＜Uu";
                kaoBtn22.Content = kaoBtn22.Tag = "('∀｀；A";
                kaoBtn23.Content = kaoBtn23.Tag = "(；￣ー￣A";
                kaoBtn24.Content = kaoBtn24.Tag = "（；・д・）";
                kaoBtn25.Content = kaoBtn25.Tag = "(；'д｀)ゞ";
                kaoBtn26.Content = kaoBtn26.Tag = "Σ(T□T)";
                kaoBtn27.Content = kaoBtn27.Tag = "(('д｀))";
                kaoBtn28.Content = kaoBtn28.Tag = "((；ﾟДﾟ)";
                kaoBtn29.Content = kaoBtn29.Tag = ":('◦ω◦｀):";
                kaoBtn30.Content = kaoBtn30.Tag = "（（（゜Д゜；）））";
                kaoBtn31.Content = kaoBtn31.Tag = "(゜ロ゜)";
                kaoBtn32.Content = kaoBtn32.Tag = "Σ(･口･)";
                kaoBtn33.Content = kaoBtn33.Tag = "(ﾟдﾟ；)";
                kaoBtn34.Content = kaoBtn34.Tag = "Σ(ﾟДﾟ)";
                kaoBtn35.Content = kaoBtn35.Tag = "∑(ΦдΦlll";
                kaoBtn36.Content = kaoBtn36.Tag = "Σ(`･ω･Ⅲ)";
                kaoBtn37.Content = kaoBtn37.Tag = "ΣΣ(ﾟДﾟ;)";
                kaoBtn38.Content = kaoBtn38.Tag = "(o'ｪﾟ):;*.";
                kaoBtn39.Content = kaoBtn39.Tag = "_('ཀ`」 ∠)_";
                kaoBtn40.Content = kaoBtn40.Tag = "｀．゜∵(゜∀゜)";
                kaoBtn41.Content = kaoBtn41.Tag = "（;ﾟ;艸;ﾟ;）";
                kaoBtn42.Content = kaoBtn42.Tag = "('エ｀；)";
                kaoBtn43.Content = kaoBtn43.Tag = "_:(´ཀ`」 ∠):";
                kaoBtn44.Content = kaoBtn44.Tag = "(((ﾟДﾟДﾟДﾟ)))";
                kaoBtn45.Content = kaoBtn45.Tag = "(;′Д`)ノ";
                kaoBtn46.Content = kaoBtn46.Tag = "(┼д┼;)";
                kaoBtn47.Content = kaoBtn47.Tag = "｜￣ω￣A；";
                kaoBtn48.Content = kaoBtn48.Tag = "('Д｀ι)";
                kaoBtn49.Content = kaoBtn49.Tag = "џ(ºДºџ)";
                kaoBtn50.Content = kaoBtn50.Tag = "°Д°";
                kaoBtn51.Content = kaoBtn51.Tag = "꒰⍨꒱";
                kaoBtn52.Content = kaoBtn52.Tag = "(・・；)";
                kaoBtn53.Content = kaoBtn53.Tag = "ఠ_ఠ";
                kaoBtn54.Content = kaoBtn54.Tag = "●.◉";
                kaoBtn55.Content = kaoBtn55.Tag = "ಠ_ರೃ";
                kaoBtn56.Content = kaoBtn56.Tag = "(・・；)";
                kaoBtn57.Content = kaoBtn57.Tag = "(●__●)";
                kaoBtn58.Content = kaoBtn58.Tag = "(⊙＿⊙)";
                kaoBtn59.Content = kaoBtn59.Tag = "(◎_◎;)";
                kaoBtn60.Content = kaoBtn60.Tag = "('◇')";
            }
            else if (menuTag == 4)
            {
                kaoBtn1.Content = kaoBtn1.Tag = "('∀｀ゞ";
                kaoBtn2.Content = kaoBtn2.Tag = "(｀∇'ゞ";
                kaoBtn3.Content = kaoBtn3.Tag = "(≧∀≦ゞ";
                kaoBtn4.Content = kaoBtn4.Tag = "ヾ(≧∇≦)ゞ";
                kaoBtn5.Content = kaoBtn5.Tag = "(＠￣￢￣＠)";
                kaoBtn6.Content = kaoBtn6.Tag = "＾ｐ＾";
                kaoBtn7.Content = kaoBtn7.Tag = "(^p^）";
                kaoBtn8.Content = kaoBtn8.Tag = "('ρ`)";
                kaoBtn9.Content = kaoBtn9.Tag = "（゜ρ゜）";
                kaoBtn10.Content = kaoBtn10.Tag = "(｡･ρ･)";
                kaoBtn11.Content = kaoBtn11.Tag = "(*'﹃｀*)";
                kaoBtn12.Content = kaoBtn12.Tag = "ξ (￣ *)";
                kaoBtn13.Content = kaoBtn13.Tag = "●ヽ(ﾟ∀ﾟ)ﾉ●";
                kaoBtn14.Content = kaoBtn14.Tag = "(・・*)ノ ⌒ξ";
                kaoBtn15.Content = kaoBtn15.Tag = "（ﾉ･∀･）ﾉ = ●";
                kaoBtn16.Content = kaoBtn16.Tag = "└|∵┌|";
                kaoBtn17.Content = kaoBtn17.Tag = "|┐∵|┘";
                kaoBtn18.Content = kaoBtn18.Tag = "|o∵|o";
                kaoBtn19.Content = kaoBtn19.Tag = "o|∵o|";
                kaoBtn20.Content = kaoBtn20.Tag = "ح˚௰˚づ";
                kaoBtn21.Content = kaoBtn21.Tag = "ヾ(^^ゞ)";
                kaoBtn22.Content = kaoBtn22.Tag = "(ﾉ･o･)ﾉ";
                kaoBtn23.Content = kaoBtn23.Tag = "┌(☆o★)┘";
                kaoBtn24.Content = kaoBtn24.Tag = "（〜^∇^)〜";
                kaoBtn25.Content = kaoBtn25.Tag = "⌌⌈╹므╹⌉⌏";
                kaoBtn26.Content = kaoBtn26.Tag = "१|˚–˚|५";
                kaoBtn27.Content = kaoBtn27.Tag = "〜(꒪꒳꒪)〜";
                kaoBtn28.Content = kaoBtn28.Tag = "(`･Д･)ノ=☆";
                kaoBtn29.Content = kaoBtn29.Tag = "(*｀□)<炎炎炎炎";
                kaoBtn30.Content = kaoBtn30.Tag = "(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧";
                kaoBtn31.Content = kaoBtn31.Tag = "(。・・)_且";
                kaoBtn32.Content = kaoBtn32.Tag = "(　ﾟДﾟ)⊃旦";
                kaoBtn33.Content = kaoBtn33.Tag = "(*｀▽')_旦~~";
                kaoBtn34.Content = kaoBtn34.Tag = "(*'・ω)o旦~┏┓";
                kaoBtn35.Content = kaoBtn35.Tag = "(ﾟ∀ﾟ人)";
                kaoBtn36.Content = kaoBtn36.Tag = "(人ゝд∩)";
                kaoBtn37.Content = kaoBtn37.Tag = "(人ゝω・）";
                kaoBtn38.Content = kaoBtn38.Tag = "(人ﾟ∀ﾟ)";
                kaoBtn39.Content = kaoBtn39.Tag = "(人ФｴФ)";
                kaoBtn40.Content = kaoBtn40.Tag = "(」ﾟДﾟ」";
                kaoBtn41.Content = kaoBtn41.Tag = "|д･)";
                kaoBtn42.Content = kaoBtn42.Tag = "|ω`)";
                kaoBtn43.Content = kaoBtn43.Tag = "|'∀｀●)";
                kaoBtn44.Content = kaoBtn44.Tag = "|･ω･｀)";
                kaoBtn45.Content = kaoBtn45.Tag = "|ω'･;)";
                kaoBtn46.Content = kaoBtn46.Tag = "|･x･`)";
                kaoBtn47.Content = kaoBtn47.Tag = "|ω-o)ﾟ";
                kaoBtn48.Content = kaoBtn48.Tag = "|ω・｀)ノ";
                kaoBtn49.Content = kaoBtn49.Tag = "┐('д｀)┌";
                kaoBtn50.Content = kaoBtn50.Tag = "┐('～｀)┌";
                kaoBtn51.Content = kaoBtn51.Tag = "╮(╯∀╰)╭";
                kaoBtn52.Content = kaoBtn52.Tag = "┐('∀｀)┌";
                kaoBtn53.Content = kaoBtn53.Tag = "┐('д`)┌";
                kaoBtn54.Content = kaoBtn54.Tag = "ヘ('－｀;)ヘ";
                kaoBtn55.Content = kaoBtn55.Tag = "ヽ(゜～゜o)ノ";
                kaoBtn56.Content = kaoBtn56.Tag = "҉*\\( 'ω' )/*҉";
                kaoBtn57.Content = kaoBtn57.Tag = "('△｀)♪";
                kaoBtn58.Content = kaoBtn58.Tag = "ρ(oμ★)";
                kaoBtn59.Content = kaoBtn59.Tag = "♫꒰･◡･๑꒱";
                kaoBtn60.Content = kaoBtn60.Tag = "∑(ﾟoﾟC=(__;";
            }
            else
            {
                kaoBtn1.Content = kaoBtn1.Tag = "චᆽච";
                kaoBtn2.Content = kaoBtn2.Tag = "ऴिाी";
                kaoBtn3.Content = kaoBtn3.Tag = "(ꀄꀾꀄ)";
                kaoBtn4.Content = kaoBtn4.Tag = "ฅ•ω•ฅ";
                kaoBtn5.Content = kaoBtn5.Tag = "(ꅈꇅꅈ)";
                kaoBtn6.Content = kaoBtn6.Tag = "(ꀂǒꀂ)";
                kaoBtn7.Content = kaoBtn7.Tag = "(ꃪꄳꃪ)";
                kaoBtn8.Content = kaoBtn8.Tag = "=ටᆼට=";
                kaoBtn9.Content = kaoBtn9.Tag = "ʘ̥ꀾʘ̥";
                kaoBtn10.Content = kaoBtn10.Tag = "=ộ⍛ộ=";
                kaoBtn11.Content = kaoBtn11.Tag = "^ↀᴥↀ^";
                kaoBtn12.Content = kaoBtn12.Tag = "โ๏∀๏ใ";
                kaoBtn13.Content = kaoBtn13.Tag = "(ΦωΦ)";
                kaoBtn14.Content = kaoBtn14.Tag = "ミ๏ｖ๏彡";
                kaoBtn15.Content = kaoBtn15.Tag = "ि०॰०ॢी";
                kaoBtn16.Content = kaoBtn16.Tag = "(ฅ'ω'ฅ)";
                kaoBtn17.Content = kaoBtn17.Tag = "(=ↀωↀ=)";
                kaoBtn18.Content = kaoBtn18.Tag = "(^･ｪ･^)";
                kaoBtn19.Content = kaoBtn19.Tag = "(^-人-^)";
                kaoBtn20.Content = kaoBtn20.Tag = "(=①ω①=)";
                kaoBtn21.Content = kaoBtn21.Tag = "(=ＴェＴ=)";
                kaoBtn22.Content = kaoBtn22.Tag = "(=ｘェｘ=)";
                kaoBtn23.Content = kaoBtn23.Tag = "・㉨・";
                kaoBtn24.Content = kaoBtn24.Tag = "తꀧత";
                kaoBtn25.Content = kaoBtn25.Tag = "ᵔᴥᵔ";
                kaoBtn26.Content = kaoBtn26.Tag = "ʕ•ᴥ•ʔ";
                kaoBtn27.Content = kaoBtn27.Tag = "ʢᵕᴗᵕʡ";
                kaoBtn28.Content = kaoBtn28.Tag = "ʕº̫͡ºʔ";
                kaoBtn29.Content = kaoBtn29.Tag = "|ｴ)･)⊃";
                kaoBtn30.Content = kaoBtn30.Tag = "Ꮚ⌀ꈊ⍉Ꮚ";
                kaoBtn31.Content = kaoBtn31.Tag = "@^ェ^@";
                kaoBtn32.Content = kaoBtn32.Tag = "Ꮚ⁰ꈊ⁰Ꮚ";
                kaoBtn33.Content = kaoBtn33.Tag = "Ꮚ'ꈊ'Ꮚ";
                kaoBtn34.Content = kaoBtn34.Tag = "˚ᆺ˚";
                kaoBtn35.Content = kaoBtn35.Tag = "(′⅄‵)";
                kaoBtn36.Content = kaoBtn36.Tag = "U・x・U";
                kaoBtn37.Content = kaoBtn37.Tag = "(•ㅅ•)";
                kaoBtn38.Content = kaoBtn38.Tag = "（ ÒㅅÓ)";
                kaoBtn39.Content = kaoBtn39.Tag = "( ･×･)";
                kaoBtn40.Content = kaoBtn40.Tag = "(๑╹ᆺ╹)";
                kaoBtn41.Content = kaoBtn41.Tag = "／(・x・)＼";
                kaoBtn42.Content = kaoBtn42.Tag = "⌒(・x・)⌒";
                kaoBtn43.Content = kaoBtn43.Tag = "U｡･.･｡U";
                kaoBtn44.Content = kaoBtn44.Tag = "U╹ x ╹U";
                kaoBtn45.Content = kaoBtn45.Tag = "／(=∵=)＼";
                kaoBtn46.Content = kaoBtn46.Tag = "U(•ㅅ•)U";
                kaoBtn47.Content = kaoBtn47.Tag = "('・×・｀)";
                kaoBtn48.Content = kaoBtn48.Tag = "○(･x･)○";
                kaoBtn49.Content = kaoBtn49.Tag = "(๑òᆺó๑)";
                kaoBtn50.Content = kaoBtn50.Tag = "⌒(•ㅅ•)⌒";
                kaoBtn51.Content = kaoBtn51.Tag = "/(•ㅅ•)\\";
                kaoBtn52.Content = kaoBtn52.Tag = "Ⴚტ◕‿◕ტჂ";
                kaoBtn53.Content = kaoBtn53.Tag = "₢⦿͡ ˒̫̮ ⦿͡ꀣ";
                kaoBtn54.Content = kaoBtn54.Tag = "☾ठ ੁठ☽";
                kaoBtn55.Content = kaoBtn55.Tag = "⊆ಠ ω ಠ⊇";
                kaoBtn56.Content = kaoBtn56.Tag = "@(･o･)@";
                kaoBtn57.Content = kaoBtn57.Tag = "@(ᵕ.ᵕ)@";
                kaoBtn58.Content = kaoBtn58.Tag = "@(･-･)@";
                kaoBtn59.Content = kaoBtn59.Tag = "@(･ェ･)@";
                kaoBtn60.Content = kaoBtn60.Tag = "└@(･ｪ･)@┐";
            }
        }
    }
}