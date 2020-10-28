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
            GetWindow(this).Close();
        }

        private void kao_button_Click(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;
            Clipboard.SetText(tag.ToString());
        }

        private void menu_click(object sender, RoutedEventArgs e)
        {
            kao_scroll_v.ScrollToTop();
            int menu_tag = Convert.ToInt32(((Button)sender).Tag);

            if (menu_tag == 0)
            {
                kao_button1.Content = kao_button1.Tag = "('∀｀）";
                kao_button2.Content = kao_button2.Tag = "（＾∀＾）";
                kao_button3.Content = kao_button3.Tag = "(｀▽')";
                kao_button4.Content = kao_button4.Tag = "('w｀*)";
                kao_button5.Content = kao_button5.Tag = "(*'∇｀*)";
                kao_button6.Content = kao_button6.Tag = "（●＞ω＜●）";
                kao_button7.Content = kao_button7.Tag = "(≧∀≦ゞ";
                kao_button8.Content = kao_button8.Tag = "(≧∇≦)b";
                kao_button9.Content = kao_button9.Tag = "(°∀°)ゝ'";
                kao_button10.Content = kao_button10.Tag = "(=ﾟ▽ﾟ)/";
                kao_button11.Content = kao_button11.Tag = "(＞Д＜)ゝ'";
                kao_button12.Content = kao_button12.Tag = "(ｏ'ｖ｀ｂ)ｂ";
                kao_button13.Content = kao_button13.Tag = "(　'∀｀)b";
                kao_button14.Content = kao_button14.Tag = "(o^-')b";
                kao_button15.Content = kao_button15.Tag = "ヾ(＾∇＾)";
                kao_button16.Content = kao_button16.Tag = "(≧∇≦)/";
                kao_button17.Content = kao_button17.Tag = "(。･∀･)ﾉ";
                kao_button18.Content = kao_button18.Tag = "( ﾟ▽ﾟ)/";
                kao_button19.Content = kao_button19.Tag = "ヾ(・ω・ｏ)";
                kao_button20.Content = kao_button20.Tag = "ヾ('￢｀)ﾉ";
                kao_button21.Content = kao_button21.Tag = "(खਉख)";
                kao_button22.Content = kao_button22.Tag = "(ಡ艸ಡ)";
                kao_button23.Content = kao_button23.Tag = "（＞ｙ＜）";
                kao_button24.Content = kao_button24.Tag = "(Ŏ艸Ŏ)";
                kao_button25.Content = kao_button25.Tag = "(^ц^ )";
                kao_button26.Content = kao_button26.Tag = "（　'∀｀）";
                kao_button27.Content = kao_button27.Tag = "（≧ｙ≦＊）";
                kao_button28.Content = kao_button28.Tag = "(*'∀｀）";
                kao_button29.Content = kao_button29.Tag = "（'υ｀）";
                kao_button30.Content = kao_button30.Tag = "(･∀･)";
                kao_button31.Content = kao_button31.Tag = "('ｖ｀)";
                kao_button32.Content = kao_button32.Tag = "(・∀・｀；)";
                kao_button33.Content = kao_button33.Tag = "(･ω･)v";
                kao_button34.Content = kao_button34.Tag = "(*ゝ∀･)v";
                kao_button35.Content = kao_button35.Tag = "(●≧ω≦)9";
                kao_button36.Content = kao_button36.Tag = "ヽ(ﾟ∀｡)ﾉ";
                kao_button37.Content = kao_button37.Tag = "＼\\\\٩( 'ω' )و //／";
                kao_button38.Content = kao_button38.Tag = "⊙▽⊙";
                kao_button39.Content = kao_button39.Tag = "（＾ｖ＾）";
                kao_button40.Content = kao_button40.Tag = "〔'∇｀〕";
                kao_button41.Content = kao_button41.Tag = "(＾ω＾)";
                kao_button42.Content = kao_button42.Tag = "ヽ(ヅ)ノ";
                kao_button43.Content = kao_button43.Tag = "(ᗒᗨᗕ)";
                kao_button44.Content = kao_button44.Tag = "≧ω≦";
                kao_button45.Content = kao_button45.Tag = "(⊙ᗜ⊙)";
                kao_button46.Content = kao_button46.Tag = "୧⍢⃝୨";
                kao_button47.Content = kao_button47.Tag = "(≧∇≦*)";
                kao_button48.Content = kao_button48.Tag = "ヽ(＾Д＾)ﾉ";
                kao_button49.Content = kao_button49.Tag = "ƪ(•◡•ƪ)\"ょぃょぃ";
                kao_button50.Content = kao_button50.Tag = "いくぞ!٩(ˊᗜˋ*) و";
                kao_button51.Content = kao_button51.Tag = "₍₍ (ง ˘ω˘ )ว ⁾⁾　ｽﾔｯ ｽﾔｯ";
                kao_button52.Content = kao_button52.Tag = "ヾ(〃l _ l)ﾉﾞ";
                kao_button53.Content = kao_button53.Tag = "⁽⁽◝( ˙ ꒳ ˙ )◜⁾⁾";
                kao_button54.Content = kao_button54.Tag = "₍₍ ◝( ´ω´ )◟ ⁾⁾";
                kao_button55.Content = kao_button55.Tag = "(ර⍵ර)✧";
                kao_button56.Content = kao_button56.Tag = "◞( ､*´▿`)､";
                kao_button57.Content = kao_button57.Tag = "꒰ ∩´∇ `∩꒱";
                kao_button58.Content = kao_button58.Tag = "(੭•̀ᴗ•̀)੭";
                kao_button59.Content = kao_button59.Tag = "ɷ◡ɷ";
                kao_button60.Content = kao_button60.Tag = "（ꉺᗜꉺ）";

            }
            else if (menu_tag == 1)
            {
                kao_button1.Content = kao_button1.Tag = "(-、-)";
                kao_button2.Content = kao_button2.Tag = "('Å｀)";
                kao_button3.Content = kao_button3.Tag = "(ﾟヘﾟ)";
                kao_button4.Content = kao_button4.Tag = "(∵）";
                kao_button5.Content = kao_button5.Tag = "（・―・）";
                kao_button6.Content = kao_button6.Tag = "（｀ー'）";
                kao_button7.Content = kao_button7.Tag = "( 'ｰ`)";
                kao_button8.Content = kao_button8.Tag = "(;'д｀)";
                kao_button9.Content = kao_button9.Tag = "('ﾟзﾟ)";
                kao_button10.Content = kao_button10.Tag = "（＞μ＜＃）";
                kao_button11.Content = kao_button11.Tag = "(・ε・｀*)";
                kao_button12.Content = kao_button12.Tag = "(ó﹏ò｡)";
                kao_button13.Content = kao_button13.Tag = "('･д･｀)";
                kao_button14.Content = kao_button14.Tag = "…φ(。。*)";
                kao_button15.Content = kao_button15.Tag = "ಠ_ಠ";
                kao_button16.Content = kao_button16.Tag = "(｀Д')";
                kao_button17.Content = kao_button17.Tag = "(`A')";
                kao_button18.Content = kao_button18.Tag = "-`д'-";
                kao_button19.Content = kao_button19.Tag = "(ಠ ∩ಠ)";
                kao_button20.Content = kao_button20.Tag = "╥﹏╥";
                kao_button21.Content = kao_button21.Tag = "(ㄒoㄒ)";
                kao_button22.Content = kao_button22.Tag = "(Ｔ▽Ｔ)";
                kao_button23.Content = kao_button23.Tag = "（ｉДｉ）";
                kao_button24.Content = kao_button24.Tag = "（'＿｀）";
                kao_button25.Content = kao_button25.Tag = "(T⌓T)";
                kao_button26.Content = kao_button26.Tag = "(ノ﹏ヽ)";
                kao_button27.Content = kao_button27.Tag = "（πーπ）";
                kao_button28.Content = kao_button28.Tag = "(つ﹏<。)";
                kao_button29.Content = kao_button29.Tag = "('Д⊂";
                kao_button30.Content = kao_button30.Tag = "('д｀)";
                kao_button31.Content = kao_button31.Tag = "つ'Д`)つ";
                kao_button32.Content = kao_button32.Tag = "（ノд｀＠）";
                kao_button33.Content = kao_button33.Tag = "(;'д｀)";
                kao_button34.Content = kao_button34.Tag = "o(；△；)o";
                kao_button35.Content = kao_button35.Tag = "('；ω；｀)";
                kao_button36.Content = kao_button36.Tag = "ヽ('Д`;)ﾉ";
                kao_button37.Content = kao_button37.Tag = "（◞‸◟）";
                kao_button38.Content = kao_button38.Tag = "(*'Д｀)=з";
                kao_button39.Content = kao_button39.Tag = "(つд⊂)";
                kao_button40.Content = kao_button40.Tag = "(ノAヽ)";
                kao_button41.Content = kao_button41.Tag = "( ,,-` ｡´-)ﾎｫｰ";
                kao_button42.Content = kao_button42.Tag = "(;´༎ຶٹ༎ຶ`)";
                kao_button43.Content = kao_button43.Tag = "꒰ ∩ ´ Д`;꒱";
                kao_button44.Content = kao_button44.Tag = "༼ಢ_ಢ༽";
                kao_button45.Content = kao_button45.Tag = "(இ﹏இ`｡)";
                kao_button46.Content = kao_button46.Tag = "༼ ༎ຶ ෴ ༎ຶ༽";
                kao_button47.Content = kao_button47.Tag = "(┳Д┳)";
                kao_button48.Content = kao_button48.Tag = "Σ(￣ロ￣lll)";
                kao_button49.Content = kao_button49.Tag = "（（（(T-T*)）））";
                kao_button50.Content = kao_button50.Tag = "＿ﾉ乙(､ﾝ､)＿";
                kao_button51.Content = kao_button51.Tag = "(_　_|||)";
                kao_button52.Content = kao_button52.Tag = "ヽ(冫、)ﾉ";
                kao_button53.Content = kao_button53.Tag = "(◔ д◔)";
                kao_button54.Content = kao_button54.Tag = "(ʘдʘ╬)";
                kao_button55.Content = kao_button55.Tag = "ლಠ益ಠ)ლ";
                kao_button56.Content = kao_button56.Tag = "( 'ｰ`)";
                kao_button57.Content = kao_button57.Tag = "…ρ(･ω`･､)";
                kao_button58.Content = kao_button58.Tag = "(｀へ′)";
                kao_button59.Content = kao_button59.Tag = "ꉂ `o´  )";
                kao_button60.Content = kao_button60.Tag = "(。ヘ°)";
            }
            else if (menu_tag == 2)
            {
                kao_button1.Content = kao_button1.Tag = "(✿ヘᴥヘ)";
                kao_button2.Content = kao_button2.Tag = "(✿╹◡╹)";
                kao_button3.Content = kao_button3.Tag = "(人◕ω◕)";
                kao_button4.Content = kao_button4.Tag = "(ㆁᴗㆁ✿)";
                kao_button5.Content = kao_button5.Tag = "(ﾉ≧ڡ≦)";
                kao_button6.Content = kao_button6.Tag = "(*бωб)";
                kao_button7.Content = kao_button7.Tag = "(〃‿〃✿)";
                kao_button8.Content = kao_button8.Tag = "❀◕ ‿ ◕❀";
                kao_button9.Content = kao_button9.Tag = "✾◕ ‿ ◕✾";
                kao_button10.Content = kao_button10.Tag = "(๑ゝڡ◕๑)";
                kao_button11.Content = kao_button11.Tag = "(・ωｰ)～☆";
                kao_button12.Content = kao_button12.Tag = "('ω｀*)";
                kao_button13.Content = kao_button13.Tag = "(ﾉ∀`♥)";
                kao_button14.Content = kao_button14.Tag = "(*≧∀≦*)";
                kao_button15.Content = kao_button15.Tag = "(*'台｀*)";
                kao_button16.Content = kao_button16.Tag = "v(^∀^*)";
                kao_button17.Content = kao_button17.Tag = "(*'ω｀*)";
                kao_button18.Content = kao_button18.Tag = "(〃▽〃)";
                kao_button19.Content = kao_button19.Tag = "(ノ▽〃)";
                kao_button20.Content = kao_button20.Tag = "(〃ー〃)";
                kao_button21.Content = kao_button21.Tag = "(〃ω〃)";
                kao_button22.Content = kao_button22.Tag = "('つヮ⊂)";
                kao_button23.Content = kao_button23.Tag = "(♡'艸`)";
                kao_button24.Content = kao_button24.Tag = "(／≧ω＼)";
                kao_button25.Content = kao_button25.Tag = "(/へ＼*)";
                kao_button26.Content = kao_button26.Tag = "(*ﾉωﾉ)";
                kao_button27.Content = kao_button27.Tag = "(ﾉ∇≦*)";
                kao_button28.Content = kao_button28.Tag = "(〃'∀｀)";
                kao_button29.Content = kao_button29.Tag = "(〃∀〃)ゞ";
                kao_button30.Content = kao_button30.Tag = "( 〃．．)";
                kao_button31.Content = kao_button31.Tag = "ღゝ◡╹)ノ♡";
                kao_button32.Content = kao_button32.Tag = "ヽ(o♡o)/";
                kao_button33.Content = kao_button33.Tag = "(灬♥ω♥灬)";
                kao_button34.Content = kao_button34.Tag = "（'・｀ ）♡";
                kao_button35.Content = kao_button35.Tag = "(⺣◡⺣)♡*";
                kao_button36.Content = kao_button36.Tag = "♡(ŐωŐ人)";
                kao_button37.Content = kao_button37.Tag = "⊂（♡⌂♡）⊃";
                kao_button38.Content = kao_button38.Tag = "♡ඩ⌔ඩ♡";
                kao_button39.Content = kao_button39.Tag = "♱♡‿♡♰";
                kao_button40.Content = kao_button40.Tag = "♡(ŐωŐ人)";
                kao_button41.Content = kao_button41.Tag = "( ˘ ³˘)";
                kao_button42.Content = kao_button42.Tag = "(~￣³￣)~";
                kao_button43.Content = kao_button43.Tag = "ლ(・ヮ・ლ)";
                kao_button44.Content = kao_button44.Tag = "⊂(・ヮ・⊂)";
                kao_button45.Content = kao_button45.Tag = "(っ'▽｀)っ";
                kao_button46.Content = kao_button46.Tag = "(っ*'∀｀*)っ";
                kao_button47.Content = kao_button47.Tag = "(.づσ▿σ)づ.";
                kao_button48.Content = kao_button48.Tag = "( ☌ω☌)ｼﾞｨｰ♥";
                kao_button49.Content = kao_button49.Tag = "ღ❤ღ´ｪ`*)";
                kao_button50.Content = kao_button50.Tag = "(ღ˘⌣˘ღ)";
                kao_button51.Content = kao_button51.Tag = "(๑♡3♡๑)";
                kao_button52.Content = kao_button52.Tag = "(♡'艸`)";
                kao_button53.Content = kao_button53.Tag = "✿♥‿♥✿";
                kao_button54.Content = kao_button54.Tag = "(♥ω♥*)";
                kao_button55.Content = kao_button55.Tag = "(*ゝω・)ﾉ";
                kao_button56.Content = kao_button56.Tag = "(๑ゝڡ◕๑)";
                kao_button57.Content = kao_button57.Tag = "(๑◕ㅂ▰)";
                kao_button58.Content = kao_button58.Tag = "(*＾∀ﾟ)ъ";
                kao_button59.Content = kao_button59.Tag = "(・ω<)";
                kao_button60.Content = kao_button60.Tag = "(◕ᴗ◕✿)";
            }
            else if (menu_tag == 3)
            {
                kao_button1.Content = kao_button1.Tag = "⚆ᗝ⚆";
                kao_button2.Content = kao_button2.Tag = "ଵ˛̼ଵ";
                kao_button3.Content = kao_button3.Tag = "˚▱˚";
                kao_button4.Content = kao_button4.Tag = "（／．＼）";
                kao_button5.Content = kao_button5.Tag = "（/｡＼)";
                kao_button6.Content = kao_button6.Tag = "(ﾟдﾟ)";
                kao_button7.Content = kao_button7.Tag = "(O∆O)";
                kao_button8.Content = kao_button8.Tag = "ゞ◎Д◎ヾ";
                kao_button9.Content = kao_button9.Tag = "（ΩДΩ）";
                kao_button10.Content = kao_button10.Tag = "《ﾟДﾟ》";
                kao_button11.Content = kao_button11.Tag = "ミ●﹏☉ミ";
                kao_button12.Content = kao_button12.Tag = "(ノдヽ)";
                kao_button13.Content = kao_button13.Tag = "(꒪⌓꒪)";
                kao_button14.Content = kao_button14.Tag = "ゞ◎Д◎ヾ";
                kao_button15.Content = kao_button15.Tag = "(⊃д⊂)";
                kao_button16.Content = kao_button16.Tag = "(ノдヽ)";
                kao_button17.Content = kao_button17.Tag = "(゜Д゜*)";
                kao_button18.Content = kao_button18.Tag = "ヽ(ﾟДﾟ)ﾉ";
                kao_button19.Content = kao_button19.Tag = "༼⁰o⁰；༽";
                kao_button20.Content = kao_button20.Tag = "(°o°:)";
                kao_button21.Content = kao_button21.Tag = "(＞△＜Uu";
                kao_button22.Content = kao_button22.Tag = "('∀｀；A";
                kao_button23.Content = kao_button23.Tag = "(；￣ー￣A";
                kao_button24.Content = kao_button24.Tag = "（；・д・）";
                kao_button25.Content = kao_button25.Tag = "(；'д｀)ゞ";
                kao_button26.Content = kao_button26.Tag = "Σ(T□T)";
                kao_button27.Content = kao_button27.Tag = "(('д｀))";
                kao_button28.Content = kao_button28.Tag = "((；ﾟДﾟ)";
                kao_button29.Content = kao_button29.Tag = ":('◦ω◦｀):";
                kao_button30.Content = kao_button30.Tag = "（（（゜Д゜；）））";
                kao_button31.Content = kao_button31.Tag = "(゜ロ゜)";
                kao_button32.Content = kao_button32.Tag = "Σ(･口･)";
                kao_button33.Content = kao_button33.Tag = "(ﾟдﾟ；)";
                kao_button34.Content = kao_button34.Tag = "Σ(ﾟДﾟ)";
                kao_button35.Content = kao_button35.Tag = "∑(ΦдΦlll";
                kao_button36.Content = kao_button36.Tag = "Σ(`･ω･Ⅲ)";
                kao_button37.Content = kao_button37.Tag = "ΣΣ(ﾟДﾟ;)";
                kao_button38.Content = kao_button38.Tag = "(o'ｪﾟ):;*.";
                kao_button39.Content = kao_button39.Tag = "_('ཀ`」 ∠)_";
                kao_button40.Content = kao_button40.Tag = "｀．゜∵(゜∀゜)";
                kao_button41.Content = kao_button41.Tag = "（;ﾟ;艸;ﾟ;）";
                kao_button42.Content = kao_button42.Tag = "('エ｀；)";
                kao_button43.Content = kao_button43.Tag = "_:(´ཀ`」 ∠):";
                kao_button44.Content = kao_button44.Tag = "(((ﾟДﾟДﾟДﾟ)))";
                kao_button45.Content = kao_button45.Tag = "(;′Д`)ノ";
                kao_button46.Content = kao_button46.Tag = "(┼д┼;)";
                kao_button47.Content = kao_button47.Tag = "｜￣ω￣A；";
                kao_button48.Content = kao_button48.Tag = "('Д｀ι)";
                kao_button49.Content = kao_button49.Tag = "џ(ºДºџ)";
                kao_button50.Content = kao_button50.Tag = "°Д°";
                kao_button51.Content = kao_button51.Tag = "꒰⍨꒱";
                kao_button52.Content = kao_button52.Tag = "(・・；)";
                kao_button53.Content = kao_button53.Tag = "ఠ_ఠ";
                kao_button54.Content = kao_button54.Tag = "●.◉";
                kao_button55.Content = kao_button55.Tag = "ಠ_ರೃ";
                kao_button56.Content = kao_button56.Tag = "(・・；)";
                kao_button57.Content = kao_button57.Tag = "(●__●)";
                kao_button58.Content = kao_button58.Tag = "(⊙＿⊙)";
                kao_button59.Content = kao_button59.Tag = "(◎_◎;)";
                kao_button60.Content = kao_button60.Tag = "('◇')";
            }
            else if (menu_tag == 4)
            {
                kao_button1.Content = kao_button1.Tag = "('∀｀ゞ";
                kao_button2.Content = kao_button2.Tag = "(｀∇'ゞ";
                kao_button3.Content = kao_button3.Tag = "(≧∀≦ゞ";
                kao_button4.Content = kao_button4.Tag = "ヾ(≧∇≦)ゞ";
                kao_button5.Content = kao_button5.Tag = "(＠￣￢￣＠)";
                kao_button6.Content = kao_button6.Tag = "＾ｐ＾";
                kao_button7.Content = kao_button7.Tag = "(^p^）";
                kao_button8.Content = kao_button8.Tag = "('ρ`)";
                kao_button9.Content = kao_button9.Tag = "（゜ρ゜）";
                kao_button10.Content = kao_button10.Tag = "(｡･ρ･)";
                kao_button11.Content = kao_button11.Tag = "(*'﹃｀*)";
                kao_button12.Content = kao_button12.Tag = "ξ (￣ *)";
                kao_button13.Content = kao_button13.Tag = "●ヽ(ﾟ∀ﾟ)ﾉ●";
                kao_button14.Content = kao_button14.Tag = "(・・*)ノ ⌒ξ";
                kao_button15.Content = kao_button15.Tag = "（ﾉ･∀･）ﾉ = ●";
                kao_button16.Content = kao_button16.Tag = "└|∵┌|";
                kao_button17.Content = kao_button17.Tag = "|┐∵|┘";
                kao_button18.Content = kao_button18.Tag = "|o∵|o";
                kao_button19.Content = kao_button19.Tag = "o|∵o|";
                kao_button20.Content = kao_button20.Tag = "ح˚௰˚づ";
                kao_button21.Content = kao_button21.Tag = "ヾ(^^ゞ)";
                kao_button22.Content = kao_button22.Tag = "(ﾉ･o･)ﾉ";
                kao_button23.Content = kao_button23.Tag = "┌(☆o★)┘";
                kao_button24.Content = kao_button24.Tag = "（〜^∇^)〜";
                kao_button25.Content = kao_button25.Tag = "⌌⌈╹므╹⌉⌏";
                kao_button26.Content = kao_button26.Tag = "१|˚–˚|५";
                kao_button27.Content = kao_button27.Tag = "〜(꒪꒳꒪)〜";
                kao_button28.Content = kao_button28.Tag = "(`･Д･)ノ=☆";
                kao_button29.Content = kao_button29.Tag = "(*｀□)<炎炎炎炎";
                kao_button30.Content = kao_button30.Tag = "(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧";
                kao_button31.Content = kao_button31.Tag = "(。・・)_且";
                kao_button32.Content = kao_button32.Tag = "(　ﾟДﾟ)⊃旦";
                kao_button33.Content = kao_button33.Tag = "(*｀▽')_旦~~";
                kao_button34.Content = kao_button34.Tag = "(*'・ω)o旦~┏┓";
                kao_button35.Content = kao_button35.Tag = "(ﾟ∀ﾟ人)";
                kao_button36.Content = kao_button36.Tag = "(人ゝд∩)";
                kao_button37.Content = kao_button37.Tag = "(人ゝω・）";
                kao_button38.Content = kao_button38.Tag = "(人ﾟ∀ﾟ)";
                kao_button39.Content = kao_button39.Tag = "(人ФｴФ)";
                kao_button40.Content = kao_button40.Tag = "(」ﾟДﾟ」";
                kao_button41.Content = kao_button41.Tag = "|д･)";
                kao_button42.Content = kao_button42.Tag = "|ω`)";
                kao_button43.Content = kao_button43.Tag = "|'∀｀●)";
                kao_button44.Content = kao_button44.Tag = "|･ω･｀)";
                kao_button45.Content = kao_button45.Tag = "|ω'･;)";
                kao_button46.Content = kao_button46.Tag = "|･x･`)";
                kao_button47.Content = kao_button47.Tag = "|ω-o)ﾟ";
                kao_button48.Content = kao_button48.Tag = "|ω・｀)ノ";
                kao_button49.Content = kao_button49.Tag = "┐('д｀)┌";
                kao_button50.Content = kao_button50.Tag = "┐('～｀)┌";
                kao_button51.Content = kao_button51.Tag = "╮(╯∀╰)╭";
                kao_button52.Content = kao_button52.Tag = "┐('∀｀)┌";
                kao_button53.Content = kao_button53.Tag = "┐('д`)┌";
                kao_button54.Content = kao_button54.Tag = "ヘ('－｀;)ヘ";
                kao_button55.Content = kao_button55.Tag = "ヽ(゜～゜o)ノ";
                kao_button56.Content = kao_button56.Tag = "҉*\\( 'ω' )/*҉";
                kao_button57.Content = kao_button57.Tag = "('△｀)♪";
                kao_button58.Content = kao_button58.Tag = "ρ(oμ★)";
                kao_button59.Content = kao_button59.Tag = "♫꒰･◡･๑꒱";
                kao_button60.Content = kao_button60.Tag = "∑(ﾟoﾟC=(__;";
            }
            else
            {
                kao_button1.Content = kao_button1.Tag = "චᆽච";
                kao_button2.Content = kao_button2.Tag = "ऴिाी";
                kao_button3.Content = kao_button3.Tag = "(ꀄꀾꀄ)";
                kao_button4.Content = kao_button4.Tag = "ฅ•ω•ฅ";
                kao_button5.Content = kao_button5.Tag = "(ꅈꇅꅈ)";
                kao_button6.Content = kao_button6.Tag = "(ꀂǒꀂ)";
                kao_button7.Content = kao_button7.Tag = "(ꃪꄳꃪ)";
                kao_button8.Content = kao_button8.Tag = "=ටᆼට=";
                kao_button9.Content = kao_button9.Tag = "ʘ̥ꀾʘ̥";
                kao_button10.Content = kao_button10.Tag = "=ộ⍛ộ=";
                kao_button11.Content = kao_button11.Tag = "^ↀᴥↀ^";
                kao_button12.Content = kao_button12.Tag = "โ๏∀๏ใ";
                kao_button13.Content = kao_button13.Tag = "(ΦωΦ)";
                kao_button14.Content = kao_button14.Tag = "ミ๏ｖ๏彡";
                kao_button15.Content = kao_button15.Tag = "ि०॰०ॢी";
                kao_button16.Content = kao_button16.Tag = "(ฅ'ω'ฅ)";
                kao_button17.Content = kao_button17.Tag = "(=ↀωↀ=)";
                kao_button18.Content = kao_button18.Tag = "(^･ｪ･^)";
                kao_button19.Content = kao_button19.Tag = "(^-人-^)";
                kao_button20.Content = kao_button20.Tag = "(=①ω①=)";
                kao_button21.Content = kao_button21.Tag = "(=ＴェＴ=)";
                kao_button22.Content = kao_button22.Tag = "(=ｘェｘ=)";
                kao_button23.Content = kao_button23.Tag = "・㉨・";
                kao_button24.Content = kao_button24.Tag = "తꀧత";
                kao_button25.Content = kao_button25.Tag = "ᵔᴥᵔ";
                kao_button26.Content = kao_button26.Tag = "ʕ•ᴥ•ʔ";
                kao_button27.Content = kao_button27.Tag = "ʢᵕᴗᵕʡ";
                kao_button28.Content = kao_button28.Tag = "ʕº̫͡ºʔ";
                kao_button29.Content = kao_button29.Tag = "|ｴ)･)⊃";
                kao_button30.Content = kao_button30.Tag = "Ꮚ⌀ꈊ⍉Ꮚ";
                kao_button31.Content = kao_button31.Tag = "@^ェ^@";
                kao_button32.Content = kao_button32.Tag = "Ꮚ⁰ꈊ⁰Ꮚ";
                kao_button33.Content = kao_button33.Tag = "Ꮚ'ꈊ'Ꮚ";
                kao_button34.Content = kao_button34.Tag = "˚ᆺ˚";
                kao_button35.Content = kao_button35.Tag = "(′⅄‵)";
                kao_button36.Content = kao_button36.Tag = "U・x・U";
                kao_button37.Content = kao_button37.Tag = "(•ㅅ•)";
                kao_button38.Content = kao_button38.Tag = "（ ÒㅅÓ)";
                kao_button39.Content = kao_button39.Tag = "( ･×･)";
                kao_button40.Content = kao_button40.Tag = "(๑╹ᆺ╹)";
                kao_button41.Content = kao_button41.Tag = "／(・x・)＼";
                kao_button42.Content = kao_button42.Tag = "⌒(・x・)⌒";
                kao_button43.Content = kao_button43.Tag = "U｡･.･｡U";
                kao_button44.Content = kao_button44.Tag = "U╹ x ╹U";
                kao_button45.Content = kao_button45.Tag = "／(=∵=)＼";
                kao_button46.Content = kao_button46.Tag = "U(•ㅅ•)U";
                kao_button47.Content = kao_button47.Tag = "('・×・｀)";
                kao_button48.Content = kao_button48.Tag = "○(･x･)○";
                kao_button49.Content = kao_button49.Tag = "(๑òᆺó๑)";
                kao_button50.Content = kao_button50.Tag = "⌒(•ㅅ•)⌒";
                kao_button51.Content = kao_button51.Tag = "/(•ㅅ•)\\";
                kao_button52.Content = kao_button52.Tag = "Ⴚტ◕‿◕ტჂ";
                kao_button53.Content = kao_button53.Tag = "₢⦿͡ ˒̫̮ ⦿͡ꀣ";
                kao_button54.Content = kao_button54.Tag = "☾ठ ੁठ☽";
                kao_button55.Content = kao_button55.Tag = "⊆ಠ ω ಠ⊇";
                kao_button56.Content = kao_button56.Tag = "@(･o･)@";
                kao_button57.Content = kao_button57.Tag = "@(ᵕ.ᵕ)@";
                kao_button58.Content = kao_button58.Tag = "@(･-･)@";
                kao_button59.Content = kao_button59.Tag = "@(･ェ･)@";
                kao_button60.Content = kao_button60.Tag = "└@(･ｪ･)@┐";
            }
        }
    }
}