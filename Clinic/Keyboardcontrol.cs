using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic
{
    public partial class KeyboardControl : UserControl
    {
        public TextBox TargetTextBox { get; set; }
        private bool isCapsLock = false;
        private bool isShift = false;

        // ── Tab order + submit button ──────────────────────────────
        private List<TextBox> _tabOrder = new List<TextBox>();
        private Button _submitButton = null;

        // ── Validation lists — stored by NAME not reference ────────
        // ── Using Name (string) means ClearTabOrder can't wipe them
        private List<string> _letterOnlyNames = new List<string>();
        private List<string> _numberOnlyNames = new List<string>();

        // ── Theme colors ──────────────────────────────────────────
        private readonly Color keyColor = Color.FromArgb(26, 74, 155);
        private readonly Color specialColor = Color.FromArgb(22, 62, 133);
        private readonly Color activeColor = Color.FromArgb(58, 143, 232);
        private readonly Color blockedColor = Color.FromArgb(180, 30, 30);

        public KeyboardControl()
        {
            InitializeComponent();
        }

        // ── Register tab order ─────────────────────────────────────
        public void RegisterTabOrder(List<TextBox> textboxes, Button submitBtn)
        {
            _tabOrder = textboxes;
            _submitButton = submitBtn;
        }

        // ── Clear tab order when switching forms ───────────────────
        public void ClearTabOrder()
        {
            _tabOrder = new List<TextBox>();
            _submitButton = null;
            _letterOnlyNames = new List<string>();
            _numberOnlyNames = new List<string>();
        }

        // ── Register letter-only boxes by their .Name property ─────
        public void RegisterLetterOnlyBoxes(List<TextBox> boxes)
        {
            _letterOnlyNames = new List<string>();
            foreach (var box in boxes)
                _letterOnlyNames.Add(box.Name);
        }

        // ── Register number-only boxes by their .Name property ─────
        public void RegisterNumberOnlyBoxes(List<TextBox> boxes)
        {
            _numberOnlyNames = new List<string>();
            foreach (var box in boxes)
                _numberOnlyNames.Add(box.Name);
        }

        // ── Check if current target is letter-only ─────────────────
        private bool IsLetterOnly()
        {
            if (TargetTextBox == null) return false;
            return _letterOnlyNames.Contains(TargetTextBox.Name);
        }

        // ── Check if current target is number-only ─────────────────
        private bool IsNumberOnly()
        {
            if (TargetTextBox == null) return false;
            return _numberOnlyNames.Contains(TargetTextBox.Name);
        }

        // ══════════════════════════════════════════════════════════
        //  TYPE CHAR — with per-textbox validation
        // ══════════════════════════════════════════════════════════
        private void TypeChar(string value)
        {
            if (TargetTextBox == null) return;

            // ── Letter-only check ──────────────────────────────────
            if (IsLetterOnly())
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        FlashBlockedKey(sender: value);
                        return;
                    }
                }
            }

            // ── Number-only check ──────────────────────────────────
            if (IsNumberOnly())
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        FlashBlockedKey(sender: value);
                        return;
                    }
                }
            }

            // ── MaxLength check ────────────────────────────────────
            if (TargetTextBox.MaxLength > 0 &&
                TargetTextBox.Text.Length >= TargetTextBox.MaxLength)
                return;

            // ── Insert the character ───────────────────────────────
            int pos = TargetTextBox.SelectionStart;
            string text = TargetTextBox.Text;

            TargetTextBox.Text = text.Insert(pos, value);
            TargetTextBox.SelectionStart = pos + value.Length;
            TargetTextBox.Focus();

            // Auto-release Shift after one keypress
            if (isShift && !isCapsLock)
            {
                isShift = false;
                UpdateKeyLabels();
            }
        }

        // ── Flash the pressed button red briefly ───────────────────
        private void FlashBlockedKey(string sender)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Text == sender)
                {
                    Color original = btn.BackColor;
                    btn.BackColor = blockedColor;

                    var timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, e) =>
                    {
                        btn.BackColor = original;
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                    break;
                }
            }
        }

        // ── Update letter keys for Caps/Shift ─────────────────────
        private void UpdateKeyLabels()
        {
            bool upper = isCapsLock ^ isShift;

            btn_Q.Text = upper ? "Q" : "q";
            btn_W.Text = upper ? "W" : "w";
            btn_E.Text = upper ? "E" : "e";
            btn_R.Text = upper ? "R" : "r";
            btn_T.Text = upper ? "T" : "t";
            btn_Y.Text = upper ? "Y" : "y";
            btn_U.Text = upper ? "U" : "u";
            btn_I.Text = upper ? "I" : "i";
            btn_O.Text = upper ? "O" : "o";
            btn_P.Text = upper ? "P" : "p";

            btn_A.Text = upper ? "A" : "a";
            btn_S.Text = upper ? "S" : "s";
            btn_D.Text = upper ? "D" : "d";
            btn_F.Text = upper ? "F" : "f";
            btn_G.Text = upper ? "G" : "g";
            btn_H.Text = upper ? "H" : "h";
            btn_J.Text = upper ? "J" : "j";
            btn_K.Text = upper ? "K" : "k";
            btn_L.Text = upper ? "L" : "l";

            btn_Z.Text = upper ? "Z" : "z";
            btn_X.Text = upper ? "X" : "x";
            btn_C.Text = upper ? "C" : "c";
            btn_V.Text = upper ? "V" : "v";
            btn_B.Text = upper ? "B" : "b";
            btn_N.Text = upper ? "N" : "n";
            btn_M.Text = upper ? "M" : "m";

            btn_Shift.BackColor = isShift ? activeColor : specialColor;
            btn_Caps.BackColor = isCapsLock ? activeColor : specialColor;
        }

        private void UpdateNumberRowLabels()
        {
            if (isShift)
            {
                btn_1.Text = "!"; btn_2.Text = "@"; btn_3.Text = "#";
                btn_4.Text = "$"; btn_5.Text = "%"; btn_6.Text = "^";
                btn_7.Text = "&"; btn_8.Text = "*"; btn_9.Text = "(";
                btn_0.Text = ")"; btn_Minus.Text = "_"; btn_Equal.Text = "+";
            }
            else
            {
                btn_1.Text = "1"; btn_2.Text = "2"; btn_3.Text = "3";
                btn_4.Text = "4"; btn_5.Text = "5"; btn_6.Text = "6";
                btn_7.Text = "7"; btn_8.Text = "8"; btn_9.Text = "9";
                btn_0.Text = "0"; btn_Minus.Text = "-"; btn_Equal.Text = "=";
            }
        }

        // ════════════════════════════════════════════════════════
        //  ROW 1 — Number keys
        // ════════════════════════════════════════════════════════
        private void btn_1_Click(object sender, EventArgs e) => TypeChar(btn_1.Text);
        private void btn_2_Click(object sender, EventArgs e) => TypeChar(btn_2.Text);
        private void btn_3_Click(object sender, EventArgs e) => TypeChar(btn_3.Text);
        private void btn_4_Click(object sender, EventArgs e) => TypeChar(btn_4.Text);
        private void btn_5_Click(object sender, EventArgs e) => TypeChar(btn_5.Text);
        private void btn_6_Click(object sender, EventArgs e) => TypeChar(btn_6.Text);
        private void btn_7_Click(object sender, EventArgs e) => TypeChar(btn_7.Text);
        private void btn_8_Click(object sender, EventArgs e) => TypeChar(btn_8.Text);
        private void btn_9_Click(object sender, EventArgs e) => TypeChar(btn_9.Text);
        private void btn_0_Click(object sender, EventArgs e) => TypeChar(btn_0.Text);
        private void btn_Minus_Click(object sender, EventArgs e) => TypeChar(btn_Minus.Text);
        private void btn_Equal_Click(object sender, EventArgs e) => TypeChar(btn_Equal.Text);

        // ════════════════════════════════════════════════════════
        //  ROW 2 — QWERTY
        // ════════════════════════════════════════════════════════
        private void btn_Q_Click(object sender, EventArgs e) => TypeChar(btn_Q.Text);
        private void btn_W_Click(object sender, EventArgs e) => TypeChar(btn_W.Text);
        private void btn_E_Click(object sender, EventArgs e) => TypeChar(btn_E.Text);
        private void btn_R_Click(object sender, EventArgs e) => TypeChar(btn_R.Text);
        private void btn_T_Click(object sender, EventArgs e) => TypeChar(btn_T.Text);
        private void btn_Y_Click(object sender, EventArgs e) => TypeChar(btn_Y.Text);
        private void btn_U_Click(object sender, EventArgs e) => TypeChar(btn_U.Text);
        private void btn_I_Click(object sender, EventArgs e) => TypeChar(btn_I.Text);
        private void btn_O_Click(object sender, EventArgs e) => TypeChar(btn_O.Text);
        private void btn_P_Click(object sender, EventArgs e) => TypeChar(btn_P.Text);

        // ════════════════════════════════════════════════════════
        //  ROW 3 — ASDF
        // ════════════════════════════════════════════════════════
        private void btn_A_Click(object sender, EventArgs e) => TypeChar(btn_A.Text);
        private void btn_S_Click(object sender, EventArgs e) => TypeChar(btn_S.Text);
        private void btn_D_Click(object sender, EventArgs e) => TypeChar(btn_D.Text);
        private void btn_F_Click(object sender, EventArgs e) => TypeChar(btn_F.Text);
        private void btn_G_Click(object sender, EventArgs e) => TypeChar(btn_G.Text);
        private void btn_H_Click(object sender, EventArgs e) => TypeChar(btn_H.Text);
        private void btn_J_Click(object sender, EventArgs e) => TypeChar(btn_J.Text);
        private void btn_K_Click(object sender, EventArgs e) => TypeChar(btn_K.Text);
        private void btn_L_Click(object sender, EventArgs e) => TypeChar(btn_L.Text);

        // ════════════════════════════════════════════════════════
        //  ROW 4 — ZXCV
        // ════════════════════════════════════════════════════════
        private void btn_Z_Click(object sender, EventArgs e) => TypeChar(btn_Z.Text);
        private void btn_X_Click(object sender, EventArgs e) => TypeChar(btn_X.Text);
        private void btn_C_Click(object sender, EventArgs e) => TypeChar(btn_C.Text);
        private void btn_V_Click(object sender, EventArgs e) => TypeChar(btn_V.Text);
        private void btn_B_Click(object sender, EventArgs e) => TypeChar(btn_B.Text);
        private void btn_N_Click(object sender, EventArgs e) => TypeChar(btn_N.Text);
        private void btn_M_Click(object sender, EventArgs e) => TypeChar(btn_M.Text);

        // ════════════════════════════════════════════════════════
        //  SPECIAL KEYS
        // ════════════════════════════════════════════════════════

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (TargetTextBox == null) return;
            int pos = TargetTextBox.SelectionStart;
            if (pos > 0)
            {
                TargetTextBox.Text = TargetTextBox.Text.Remove(pos - 1, 1);
                TargetTextBox.SelectionStart = pos - 1;
                TargetTextBox.Focus();
            }
        }

        private void btn_Space_Click(object sender, EventArgs e)
        {
            // Block space in number-only textboxes
            if (IsNumberOnly())
            {
                FlashBlockedKey("Space");
                return;
            }
            TypeChar(" ");
        }

        // ── ENTER key ─────────────────────────────────────────────
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (TargetTextBox == null || _tabOrder == null || _tabOrder.Count == 0)
                return;

            int currentIndex = _tabOrder.IndexOf(TargetTextBox);

            if (currentIndex == -1)
            {
                TargetTextBox.Focus();
                return;
            }

            if (currentIndex == _tabOrder.Count - 1)
            {
                Visible = false;
                _submitButton?.PerformClick();
            }
            else
            {
                TextBox nextBox = _tabOrder[currentIndex + 1];
                TargetTextBox = nextBox;
                nextBox.Focus();
            }
        }

        private void btn_Caps_Click(object sender, EventArgs e)
        {
            isCapsLock = !isCapsLock;
            UpdateKeyLabels();
            UpdateNumberRowLabels();
        }

        private void btn_Shift_Click(object sender, EventArgs e)
        {
            isShift = !isShift;
            UpdateKeyLabels();
            UpdateNumberRowLabels();
        }

        private void btn_Period_Click(object sender, EventArgs e) => TypeChar(isShift ? ">" : ".");
        private void btn_Comma_Click(object sender, EventArgs e) => TypeChar(isShift ? "<" : ",");
        private void btn_Slash_Click(object sender, EventArgs e) => TypeChar(isShift ? "?" : "/");
        private void btn_Semicolon_Click(object sender, EventArgs e) => TypeChar(isShift ? ":" : ";");
        private void btn_Apostrophe_Click(object sender, EventArgs e) => TypeChar(isShift ? "\"" : "'");
    }
}