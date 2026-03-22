namespace Clinic
{
    partial class KeyboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        // ═══════════════════════════════════════════════════════
        //  Declare every button explicitly (no loops/arrays)
        // ═══════════════════════════════════════════════════════

        // Row 1 — Numbers
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button btn_Backspace;

        // Row 2 — QWERTY
        private System.Windows.Forms.Button btn_Q;
        private System.Windows.Forms.Button btn_W;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.Button btn_T;
        private System.Windows.Forms.Button btn_Y;
        private System.Windows.Forms.Button btn_U;
        private System.Windows.Forms.Button btn_I;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Button btn_P;

        // Row 3 — ASDF
        private System.Windows.Forms.Button btn_Caps;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_H;
        private System.Windows.Forms.Button btn_J;
        private System.Windows.Forms.Button btn_K;
        private System.Windows.Forms.Button btn_L;
        private System.Windows.Forms.Button btn_Semicolon;
        private System.Windows.Forms.Button btn_Apostrophe;
        private System.Windows.Forms.Button btn_Enter;

        // Row 4 — ZXCV
        private System.Windows.Forms.Button btn_Shift;
        private System.Windows.Forms.Button btn_Z;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_V;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_N;
        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.Button btn_Comma;
        private System.Windows.Forms.Button btn_Period;
        private System.Windows.Forms.Button btn_Slash;

        // Row 5 — Spacebar
        private System.Windows.Forms.Button btn_Space;

        private void InitializeComponent()
        {
            int pad = 8;
            int gap = 5;
            int kw = 68;
            int kh = 62;
            int step = kw + gap;  // 73

            int totalW = 13 * kw + 12 * gap + 2 * pad; // 960
            int innerW = totalW - 2 * pad;              // 944

            int capsW = 70;
            int enterW = 944 - (11 * kw + 10 * gap) - 2 * gap - capsW;
            int shiftW = 944 - (10 * kw + 9 * gap) - gap;
            int spaceW = innerW;

            // ── Fonts ─────────────────────────────────────────────
            var keyFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            var specialFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // ══════════════════════════════════════════════════════
            //  COLORS — matched to the form's blue theme
            //
            //  Form background  : light blue  #CCDFF0  (173,207,229) -- used as keyboard bg
            //  Standard key     : dark blue   #1A4A9B  (26, 74, 155) -- matches label/button color
            //  Special key      : deeper blue #163E85  (22, 62, 133) -- slightly darker for Caps/Shift/Enter
            //  Key text         : white       #FFFFFF
            //  Border           : medium blue #2E6DB4  (46,109,180)
            //  Hover            : bright blue #3A8FE8  (58,143,232)  -- lighter blue highlight
            //  Mouse down       : pressed     #0F3272  (15, 50,114)
            // ══════════════════════════════════════════════════════
            var bgColor = System.Drawing.Color.FromArgb(173, 207, 229); // light blue — keyboard background
            var keyColor = System.Drawing.Color.FromArgb(26, 74, 155); // dark blue  — standard keys
            var specialColor = System.Drawing.Color.FromArgb(22, 62, 133); // deeper blue — Caps/Shift/Enter/Backspace/Space
            var hoverColor = System.Drawing.Color.FromArgb(58, 143, 232); // bright blue — hover
            var pressColor = System.Drawing.Color.FromArgb(15, 50, 114); // pressed
            var borderColor = System.Drawing.Color.FromArgb(46, 109, 180); // border
            var keyFore = System.Drawing.Color.White;

            // ── Helper ────────────────────────────────────────────
            System.Windows.Forms.Button MakeKey(
                string text,
                System.Drawing.Point loc,
                System.Drawing.Size size,
                System.Drawing.Font font,
                System.Drawing.Color back)
            {
                var b = new System.Windows.Forms.Button
                {
                    Text = text,
                    Location = loc,
                    Size = size,
                    Font = font,
                    BackColor = back,
                    ForeColor = keyFore,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Cursor = System.Windows.Forms.Cursors.Hand,
                    TabStop = false,
                    UseVisualStyleBackColor = false,
                };
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = borderColor;
                b.FlatAppearance.MouseOverBackColor = hoverColor;
                b.FlatAppearance.MouseDownBackColor = pressColor;
                return b;
            }

            var keySize = new System.Drawing.Size(kw, kh);
            var backspaceKey = new System.Drawing.Size(kw, kh);
            var capsKey = new System.Drawing.Size(capsW, kh);
            var enterKey = new System.Drawing.Size(enterW, kh);
            var shiftKey = new System.Drawing.Size(shiftW, kh);
            var spaceKey = new System.Drawing.Size(spaceW, kh);

            // ════════════════════════════════════════════════════
            //  ROW 1 — Numbers + Backspace
            // ════════════════════════════════════════════════════
            int r1y = pad;

            btn_1 = MakeKey("1", new System.Drawing.Point(pad + step * 0, r1y), keySize, keyFont, keyColor);
            btn_2 = MakeKey("2", new System.Drawing.Point(pad + step * 1, r1y), keySize, keyFont, keyColor);
            btn_3 = MakeKey("3", new System.Drawing.Point(pad + step * 2, r1y), keySize, keyFont, keyColor);
            btn_4 = MakeKey("4", new System.Drawing.Point(pad + step * 3, r1y), keySize, keyFont, keyColor);
            btn_5 = MakeKey("5", new System.Drawing.Point(pad + step * 4, r1y), keySize, keyFont, keyColor);
            btn_6 = MakeKey("6", new System.Drawing.Point(pad + step * 5, r1y), keySize, keyFont, keyColor);
            btn_7 = MakeKey("7", new System.Drawing.Point(pad + step * 6, r1y), keySize, keyFont, keyColor);
            btn_8 = MakeKey("8", new System.Drawing.Point(pad + step * 7, r1y), keySize, keyFont, keyColor);
            btn_9 = MakeKey("9", new System.Drawing.Point(pad + step * 8, r1y), keySize, keyFont, keyColor);
            btn_0 = MakeKey("0", new System.Drawing.Point(pad + step * 9, r1y), keySize, keyFont, keyColor);
            btn_Minus = MakeKey("-", new System.Drawing.Point(pad + step * 10, r1y), keySize, keyFont, keyColor);
            btn_Equal = MakeKey("=", new System.Drawing.Point(pad + step * 11, r1y), keySize, keyFont, keyColor);
            btn_Backspace = MakeKey("⌫", new System.Drawing.Point(pad + step * 12, r1y), backspaceKey, specialFont, specialColor);

            // ════════════════════════════════════════════════════
            //  ROW 2 — QWERTY
            // ════════════════════════════════════════════════════
            int r2y = r1y + kh + gap;

            btn_Q = MakeKey("Q", new System.Drawing.Point(pad + step * 0, r2y), keySize, keyFont, keyColor);
            btn_W = MakeKey("W", new System.Drawing.Point(pad + step * 1, r2y), keySize, keyFont, keyColor);
            btn_E = MakeKey("E", new System.Drawing.Point(pad + step * 2, r2y), keySize, keyFont, keyColor);
            btn_R = MakeKey("R", new System.Drawing.Point(pad + step * 3, r2y), keySize, keyFont, keyColor);
            btn_T = MakeKey("T", new System.Drawing.Point(pad + step * 4, r2y), keySize, keyFont, keyColor);
            btn_Y = MakeKey("Y", new System.Drawing.Point(pad + step * 5, r2y), keySize, keyFont, keyColor);
            btn_U = MakeKey("U", new System.Drawing.Point(pad + step * 6, r2y), keySize, keyFont, keyColor);
            btn_I = MakeKey("I", new System.Drawing.Point(pad + step * 7, r2y), keySize, keyFont, keyColor);
            btn_O = MakeKey("O", new System.Drawing.Point(pad + step * 8, r2y), keySize, keyFont, keyColor);
            btn_P = MakeKey("P", new System.Drawing.Point(pad + step * 9, r2y), keySize, keyFont, keyColor);

            // ════════════════════════════════════════════════════
            //  ROW 3 — Caps + ASDF + Enter
            // ════════════════════════════════════════════════════
            int r3y = r2y + kh + gap;
            int r3x = pad + capsW + gap;

            btn_Caps = MakeKey("Caps", new System.Drawing.Point(pad, r3y), capsKey, specialFont, specialColor);
            btn_A = MakeKey("A", new System.Drawing.Point(r3x + step * 0, r3y), keySize, keyFont, keyColor);
            btn_S = MakeKey("S", new System.Drawing.Point(r3x + step * 1, r3y), keySize, keyFont, keyColor);
            btn_D = MakeKey("D", new System.Drawing.Point(r3x + step * 2, r3y), keySize, keyFont, keyColor);
            btn_F = MakeKey("F", new System.Drawing.Point(r3x + step * 3, r3y), keySize, keyFont, keyColor);
            btn_G = MakeKey("G", new System.Drawing.Point(r3x + step * 4, r3y), keySize, keyFont, keyColor);
            btn_H = MakeKey("H", new System.Drawing.Point(r3x + step * 5, r3y), keySize, keyFont, keyColor);
            btn_J = MakeKey("J", new System.Drawing.Point(r3x + step * 6, r3y), keySize, keyFont, keyColor);
            btn_K = MakeKey("K", new System.Drawing.Point(r3x + step * 7, r3y), keySize, keyFont, keyColor);
            btn_L = MakeKey("L", new System.Drawing.Point(r3x + step * 8, r3y), keySize, keyFont, keyColor);
            btn_Semicolon = MakeKey(";", new System.Drawing.Point(r3x + step * 9, r3y), keySize, keyFont, keyColor);
            btn_Apostrophe = MakeKey("'", new System.Drawing.Point(r3x + step * 10, r3y), keySize, keyFont, keyColor);
            btn_Enter = MakeKey("Enter", new System.Drawing.Point(r3x + step * 11, r3y), enterKey, specialFont, specialColor);

            // ════════════════════════════════════════════════════
            //  ROW 4 — Shift + ZXCV
            // ════════════════════════════════════════════════════
            int r4y = r3y + kh + gap;
            int r4x = pad + shiftW + gap;

            btn_Shift = MakeKey("⇧ Shift", new System.Drawing.Point(pad, r4y), shiftKey, specialFont, specialColor);
            btn_Z = MakeKey("Z", new System.Drawing.Point(r4x + step * 0, r4y), keySize, keyFont, keyColor);
            btn_X = MakeKey("X", new System.Drawing.Point(r4x + step * 1, r4y), keySize, keyFont, keyColor);
            btn_C = MakeKey("C", new System.Drawing.Point(r4x + step * 2, r4y), keySize, keyFont, keyColor);
            btn_V = MakeKey("V", new System.Drawing.Point(r4x + step * 3, r4y), keySize, keyFont, keyColor);
            btn_B = MakeKey("B", new System.Drawing.Point(r4x + step * 4, r4y), keySize, keyFont, keyColor);
            btn_N = MakeKey("N", new System.Drawing.Point(r4x + step * 5, r4y), keySize, keyFont, keyColor);
            btn_M = MakeKey("M", new System.Drawing.Point(r4x + step * 6, r4y), keySize, keyFont, keyColor);
            btn_Comma = MakeKey(",", new System.Drawing.Point(r4x + step * 7, r4y), keySize, keyFont, keyColor);
            btn_Period = MakeKey(".", new System.Drawing.Point(r4x + step * 8, r4y), keySize, keyFont, keyColor);
            btn_Slash = MakeKey("/", new System.Drawing.Point(r4x + step * 9, r4y), keySize, keyFont, keyColor);

            // ════════════════════════════════════════════════════
            //  ROW 5 — Spacebar
            // ════════════════════════════════════════════════════
            int r5y = r4y + kh + gap;

            btn_Space = MakeKey("Space", new System.Drawing.Point(pad, r5y), spaceKey, specialFont, specialColor);

            // ═══════════════════════════════════════════════════
            //  Wire up Click events
            // ═══════════════════════════════════════════════════
            btn_1.Click += btn_1_Click;
            btn_2.Click += btn_2_Click;
            btn_3.Click += btn_3_Click;
            btn_4.Click += btn_4_Click;
            btn_5.Click += btn_5_Click;
            btn_6.Click += btn_6_Click;
            btn_7.Click += btn_7_Click;
            btn_8.Click += btn_8_Click;
            btn_9.Click += btn_9_Click;
            btn_0.Click += btn_0_Click;
            btn_Minus.Click += btn_Minus_Click;
            btn_Equal.Click += btn_Equal_Click;
            btn_Backspace.Click += btn_Backspace_Click;

            btn_Q.Click += btn_Q_Click;
            btn_W.Click += btn_W_Click;
            btn_E.Click += btn_E_Click;
            btn_R.Click += btn_R_Click;
            btn_T.Click += btn_T_Click;
            btn_Y.Click += btn_Y_Click;
            btn_U.Click += btn_U_Click;
            btn_I.Click += btn_I_Click;
            btn_O.Click += btn_O_Click;
            btn_P.Click += btn_P_Click;

            btn_Caps.Click += btn_Caps_Click;
            btn_A.Click += btn_A_Click;
            btn_S.Click += btn_S_Click;
            btn_D.Click += btn_D_Click;
            btn_F.Click += btn_F_Click;
            btn_G.Click += btn_G_Click;
            btn_H.Click += btn_H_Click;
            btn_J.Click += btn_J_Click;
            btn_K.Click += btn_K_Click;
            btn_L.Click += btn_L_Click;
            btn_Semicolon.Click += btn_Semicolon_Click;
            btn_Apostrophe.Click += btn_Apostrophe_Click;
            btn_Enter.Click += btn_Enter_Click;

            btn_Shift.Click += btn_Shift_Click;
            btn_Z.Click += btn_Z_Click;
            btn_X.Click += btn_X_Click;
            btn_C.Click += btn_C_Click;
            btn_V.Click += btn_V_Click;
            btn_B.Click += btn_B_Click;
            btn_N.Click += btn_N_Click;
            btn_M.Click += btn_M_Click;
            btn_Comma.Click += btn_Comma_Click;
            btn_Period.Click += btn_Period_Click;
            btn_Slash.Click += btn_Slash_Click;

            btn_Space.Click += btn_Space_Click;

            // ═══════════════════════════════════════════════════
            //  Control size — exact fit, no gaps
            // ═══════════════════════════════════════════════════
            int totalH = pad + 5 * (kh + gap) - gap + pad;

            this.BackColor = bgColor;  // ← light blue matching the form background
            this.Size = new System.Drawing.Size(totalW, totalH);

            // ── Add every button ──────────────────────────────────
            this.Controls.Add(btn_1);
            this.Controls.Add(btn_2);
            this.Controls.Add(btn_3);
            this.Controls.Add(btn_4);
            this.Controls.Add(btn_5);
            this.Controls.Add(btn_6);
            this.Controls.Add(btn_7);
            this.Controls.Add(btn_8);
            this.Controls.Add(btn_9);
            this.Controls.Add(btn_0);
            this.Controls.Add(btn_Minus);
            this.Controls.Add(btn_Equal);
            this.Controls.Add(btn_Backspace);
            this.Controls.Add(btn_Q);
            this.Controls.Add(btn_W);
            this.Controls.Add(btn_E);
            this.Controls.Add(btn_R);
            this.Controls.Add(btn_T);
            this.Controls.Add(btn_Y);
            this.Controls.Add(btn_U);
            this.Controls.Add(btn_I);
            this.Controls.Add(btn_O);
            this.Controls.Add(btn_P);
            this.Controls.Add(btn_Caps);
            this.Controls.Add(btn_A);
            this.Controls.Add(btn_S);
            this.Controls.Add(btn_D);
            this.Controls.Add(btn_F);
            this.Controls.Add(btn_G);
            this.Controls.Add(btn_H);
            this.Controls.Add(btn_J);
            this.Controls.Add(btn_K);
            this.Controls.Add(btn_L);
            this.Controls.Add(btn_Semicolon);
            this.Controls.Add(btn_Apostrophe);
            this.Controls.Add(btn_Enter);
            this.Controls.Add(btn_Shift);
            this.Controls.Add(btn_Z);
            this.Controls.Add(btn_X);
            this.Controls.Add(btn_C);
            this.Controls.Add(btn_V);
            this.Controls.Add(btn_B);
            this.Controls.Add(btn_N);
            this.Controls.Add(btn_M);
            this.Controls.Add(btn_Comma);
            this.Controls.Add(btn_Period);
            this.Controls.Add(btn_Slash);
            this.Controls.Add(btn_Space);
        }
    }
}