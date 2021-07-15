using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuickAndDirtyNoteVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Variables.
        string selectedNote = string.Empty;

        // Methods.
        // Resets the background color of all the fret buttons back to their original values.
        private void ChangeBackgroundFretsBackToDefault()
        {
            // Frets e.
            Fret_e_0.ClearValue(Button.BackgroundProperty);
            Fret_e_1.ClearValue(Button.BackgroundProperty);
            Fret_e_2.ClearValue(Button.BackgroundProperty);
            Fret_e_3.ClearValue(Button.BackgroundProperty);
            Fret_e_4.ClearValue(Button.BackgroundProperty);
            Fret_e_5.ClearValue(Button.BackgroundProperty);
            Fret_e_6.ClearValue(Button.BackgroundProperty);
            Fret_e_7.ClearValue(Button.BackgroundProperty);
            Fret_e_8.ClearValue(Button.BackgroundProperty);
            Fret_e_9.ClearValue(Button.BackgroundProperty);
            Fret_e_10.ClearValue(Button.BackgroundProperty);
            Fret_e_11.ClearValue(Button.BackgroundProperty);
            Fret_e_12.ClearValue(Button.BackgroundProperty);

            // Frets B.
            Fret_B_0.ClearValue(Button.BackgroundProperty);
            Fret_B_1.ClearValue(Button.BackgroundProperty);
            Fret_B_2.ClearValue(Button.BackgroundProperty);
            Fret_B_3.ClearValue(Button.BackgroundProperty);
            Fret_B_4.ClearValue(Button.BackgroundProperty);
            Fret_B_5.ClearValue(Button.BackgroundProperty);
            Fret_B_6.ClearValue(Button.BackgroundProperty);
            Fret_B_7.ClearValue(Button.BackgroundProperty);
            Fret_B_8.ClearValue(Button.BackgroundProperty);
            Fret_B_9.ClearValue(Button.BackgroundProperty);
            Fret_B_10.ClearValue(Button.BackgroundProperty);
            Fret_B_11.ClearValue(Button.BackgroundProperty);
            Fret_B_12.ClearValue(Button.BackgroundProperty);

            // Frets G.
            Fret_G_0.ClearValue(Button.BackgroundProperty);
            Fret_G_1.ClearValue(Button.BackgroundProperty);
            Fret_G_2.ClearValue(Button.BackgroundProperty);
            Fret_G_3.ClearValue(Button.BackgroundProperty);
            Fret_G_4.ClearValue(Button.BackgroundProperty);
            Fret_G_5.ClearValue(Button.BackgroundProperty);
            Fret_G_6.ClearValue(Button.BackgroundProperty);
            Fret_G_7.ClearValue(Button.BackgroundProperty);
            Fret_G_8.ClearValue(Button.BackgroundProperty);
            Fret_G_9.ClearValue(Button.BackgroundProperty);
            Fret_G_10.ClearValue(Button.BackgroundProperty);
            Fret_G_11.ClearValue(Button.BackgroundProperty);
            Fret_G_12.ClearValue(Button.BackgroundProperty);

            // Frets D.
            Fret_D_0.ClearValue(Button.BackgroundProperty);
            Fret_D_1.ClearValue(Button.BackgroundProperty);
            Fret_D_2.ClearValue(Button.BackgroundProperty);
            Fret_D_3.ClearValue(Button.BackgroundProperty);
            Fret_D_4.ClearValue(Button.BackgroundProperty);
            Fret_D_5.ClearValue(Button.BackgroundProperty);
            Fret_D_6.ClearValue(Button.BackgroundProperty);
            Fret_D_7.ClearValue(Button.BackgroundProperty);
            Fret_D_8.ClearValue(Button.BackgroundProperty);
            Fret_D_9.ClearValue(Button.BackgroundProperty);
            Fret_D_10.ClearValue(Button.BackgroundProperty);
            Fret_D_11.ClearValue(Button.BackgroundProperty);
            Fret_D_12.ClearValue(Button.BackgroundProperty);

            // Frets A.
            Fret_A_0.ClearValue(Button.BackgroundProperty);
            Fret_A_1.ClearValue(Button.BackgroundProperty);
            Fret_A_2.ClearValue(Button.BackgroundProperty);
            Fret_A_3.ClearValue(Button.BackgroundProperty);
            Fret_A_4.ClearValue(Button.BackgroundProperty);
            Fret_A_5.ClearValue(Button.BackgroundProperty);
            Fret_A_6.ClearValue(Button.BackgroundProperty);
            Fret_A_7.ClearValue(Button.BackgroundProperty);
            Fret_A_8.ClearValue(Button.BackgroundProperty);
            Fret_A_9.ClearValue(Button.BackgroundProperty);
            Fret_A_10.ClearValue(Button.BackgroundProperty);
            Fret_A_11.ClearValue(Button.BackgroundProperty);
            Fret_A_12.ClearValue(Button.BackgroundProperty);

            // Frets E.
            Fret_E_0.ClearValue(Button.BackgroundProperty);
            Fret_E_1.ClearValue(Button.BackgroundProperty);
            Fret_E_2.ClearValue(Button.BackgroundProperty);
            Fret_E_3.ClearValue(Button.BackgroundProperty);
            Fret_E_4.ClearValue(Button.BackgroundProperty);
            Fret_E_5.ClearValue(Button.BackgroundProperty);
            Fret_E_6.ClearValue(Button.BackgroundProperty);
            Fret_E_7.ClearValue(Button.BackgroundProperty);
            Fret_E_8.ClearValue(Button.BackgroundProperty);
            Fret_E_9.ClearValue(Button.BackgroundProperty);
            Fret_E_10.ClearValue(Button.BackgroundProperty);
            Fret_E_11.ClearValue(Button.BackgroundProperty);
            Fret_E_12.ClearValue(Button.BackgroundProperty);
        }

        // Resets the background color of all the note buttons back to their original values.
        private void ChangeBackgroundNotesToDefault()
        {
            // Note A.
            Note_a.ClearValue(Button.BackgroundProperty);
            Note_A.ClearValue(Button.BackgroundProperty);

            // Note G.
            Note_g.ClearValue(Button.BackgroundProperty);
            Note_G.ClearValue(Button.BackgroundProperty);

            // Note F.
            Note_f.ClearValue(Button.BackgroundProperty);
            Note_F.ClearValue(Button.BackgroundProperty);

            // Note E.
            Note_e.ClearValue(Button.BackgroundProperty);
            Note_E.ClearValue(Button.BackgroundProperty);

            // Note D.
            Note_d.ClearValue(Button.BackgroundProperty);
            Note_D.ClearValue(Button.BackgroundProperty);

            // Note C.
            Note_c.ClearValue(Button.BackgroundProperty);
            Note_C.ClearValue(Button.BackgroundProperty);

            // Note B.
            Note_B.ClearValue(Button.BackgroundProperty);
        }

        // Resets the background color of all the note type buttons back to their original values.
        private void ChangeBackgroundNoteTypesToDefault()
        {
            // Note types sharp, Flat and Normal.
            Note_Sharp.ClearValue(Button.BackgroundProperty);
            Note_Flat.ClearValue(Button.BackgroundProperty);
            Note_Normal.ClearValue(Button.BackgroundProperty);
        }

        // Reset the value of the selectedNote variable.
        private void ResetSelectedNote()
        {
            // Reset selectedNote.
            selectedNote = string.Empty;
        }

        // Highlight normal note type button.
        private void HighlightNormalButton()
        {
            // Highlight normal note type button.
            Note_Normal.Background = new SolidColorBrush(Colors.LightPink);
        }

        // Highlight B frets, note and normal buttons also set selectedNote to B.
        private void HighlightB()
        {
            // Frets.
            Fret_e_7.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_0.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_12.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_5.Background = new SolidColorBrush(Colors.LightSkyBlue);            
            Fret_A_2.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_7.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Note.
            Note_B.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "B";

            // Highlight normal note type button.
            HighlightNormalButton();
        }

        // Highlight B flat frets and note buttons also set selectedNote to B.
        private void HighlightBFlat()
        {
            // Frets.
            Fret_e_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_3.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_6.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Note.
            Note_B.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "B";
        }

        // Highlight A sharp frets and notes buttons also set selectedNote to A.
        private void HighlightASharp()
        {
            // Frets.
            Fret_e_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_3.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_6.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_a.Background = new SolidColorBrush(Colors.LightPink);
            Note_A.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "A";
        }

        // Highlight A frets, notes and normal buttons also set selectedNote to A.
        private void HighlightA()
        {
            // Frets.
            Fret_e_5.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_10.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_2.Background = new SolidColorBrush(Colors.LightSkyBlue);            
            Fret_D_7.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_0.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_12.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_5.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_a.Background = new SolidColorBrush(Colors.LightPink);
            Note_A.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "A";

            // Highlight normal note type
            HighlightNormalButton();
        }

        // Highlight A flat frets and notes buttons also set selectedNote to A.
        private void HighlightAFlat()
        {
            // Frets.
            Fret_e_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_4.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_a.Background = new SolidColorBrush(Colors.LightPink);
            Note_A.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "A";
        }

        // Highlight G sharp frets and notes buttons also set selectedNote to G.
        private void HighlightGSharp()
        {
            // Frets.
            Fret_e_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_4.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_g.Background = new SolidColorBrush(Colors.LightPink);
            Note_G.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "G";
        }

        // Highlight G frets, notes and normal buttons also set selectedNote to G.
        private void HighlightG()
        {
            // Frets.
            Fret_e_3.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_0.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_12.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_5.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_10.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_3.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_g.Background = new SolidColorBrush(Colors.LightPink);
            Note_G.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "G";

            // Highlight normal note type
            HighlightNormalButton();
        }

        // Highlight G flat frets and notes buttons also set selectedNote to G.
        private void HighlightGFlat()
        {
            // Frets.
            Fret_e_2.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_7.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_2.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_g.Background = new SolidColorBrush(Colors.LightPink);
            Note_G.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "G";
        }

        // Highlight F sharp frets and notes buttons also set selectedNote to F.
        private void HighlightFSharp()
        {
            // Frets.
            Fret_e_2.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_7.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_2.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_f.Background = new SolidColorBrush(Colors.LightPink);
            Note_F.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "F";
        }

        // Highlight F frets, notes and normal buttons also set selectedNote to F.
        private void HighlightF()
        {
            // Frets.
            Fret_e_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_10.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_3.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_1.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_f.Background = new SolidColorBrush(Colors.LightPink);
            Note_F.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "F";

            // Highlight normal note type
            HighlightNormalButton();
        }

        // Highlight E frets, notes and normal buttons also set selectedNote to E.
        private void HighlightE()
        {
            // Frets.
            Fret_e_0.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_e_12.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_5.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_2.Background = new SolidColorBrush(Colors.LightSkyBlue);           
            Fret_A_7.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_0.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_12.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_e.Background = new SolidColorBrush(Colors.LightPink);
            Note_E.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "E";

            // Highlight normal note type
            HighlightNormalButton();
        }

        // Highlight E flat frets and notes buttons also set selectedNote to E.
        private void HighlightEFlat()
        {
            // Frets.
            Fret_e_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_11.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_e.Background = new SolidColorBrush(Colors.LightPink);
            Note_E.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "E";
        }

        // Highlight D sharp frets and notes buttons also set selectedNote to D.
        private void HighlightDSharp()
        {
            // Frets.
            Fret_e_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_11.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_d.Background = new SolidColorBrush(Colors.LightPink);
            Note_D.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "D";
        }

        // Highlight D frets, notes and normal buttons also set selectedNote to D.
        private void HighlightD()
        {
            // Frets.
            Fret_e_10.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_3.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_7.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_0.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_12.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_5.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_10.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_d.Background = new SolidColorBrush(Colors.LightPink);
            Note_D.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "D";

            // Highlight normal note type
            HighlightNormalButton();
        }

        // Highlight D flat frets and notes buttons also set selectedNote to D.
        private void HighlightDFlat()
        {
            // Frets.
            Fret_e_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_2.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_9.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_d.Background = new SolidColorBrush(Colors.LightPink);
            Note_D.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "D";
        }

        // Highlight C sharp frets and notes buttons also set selectedNote to C.
        private void HighlightCSharp()
        {
            // Frets.
            Fret_e_9.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_2.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_6.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_11.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_4.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_9.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_c.Background = new SolidColorBrush(Colors.LightPink);
            Note_C.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "C";
        }

        // Highlight C frets, notes and normal buttons also set selectedNote to C.
        private void HighlightC()
        {
            // Frets.
            Fret_e_8.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_B_1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_G_5.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_D_10.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_A_3.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Fret_E_8.Background = new SolidColorBrush(Colors.LightSkyBlue);

            // Notes.
            Note_c.Background = new SolidColorBrush(Colors.LightPink);
            Note_C.Background = new SolidColorBrush(Colors.LightPink);

            // Set selectedNote.
            selectedNote = "C";

            // Highlight normal note type
            HighlightNormalButton();
        }        

        // Logic to get the right note and flat frets highlighted.
        private void MakeFlat()
        {
            // Check if there is a note selected.
            if (selectedNote != string.Empty)
            {
                // Determine the selected note and call method to highlight the flat version of it.
                switch (selectedNote)
                {
                    case "A":
                        HighlightAFlat();
                        break;

                    case "B":
                        HighlightBFlat();
                        break;
                    case "D":
                        HighlightDFlat();
                        break;

                    case "E":
                        HighlightEFlat();
                        break;

                    case "G":
                        HighlightGFlat();
                        break;
                }

                // Highlight the flat button.
                Note_Flat.Background = new SolidColorBrush(Colors.LightPink);
            }

            // If there is no note selected, then reset the note type buttons.
            else
            {
                ChangeBackgroundNoteTypesToDefault();
            }
        }

        // Logic to get the right note and sharp frets highlighted.
        private void MakeSharp()
        {
            // Check if there is a note selected.
            if (selectedNote != string.Empty)
            {
                // Determine the selected note and call method to highlight the sharp version of it.
                switch (selectedNote)
                {
                    case "A":
                        HighlightASharp();
                        break;

                    case "C":
                        HighlightCSharp();
                        break;
                    case "D":
                        HighlightDSharp();
                        break;

                    case "F":
                        HighlightFSharp();
                        break;

                    case "G":
                        HighlightGSharp();
                        break;
                }

                // Highlight the sharp button.
                Note_Sharp.Background = new SolidColorBrush(Colors.LightPink);
            }

            // If there is no note selected, then reset the note type buttons.
            else
            {
                ChangeBackgroundNoteTypesToDefault();
            }
        }

        // Logic to get the right note and normal frets highlighted.
        private void MakeNormal()
        {
            // Check if there is a note selected.
            if (selectedNote != string.Empty)
            {
                // Determine the selected note and call method to highlight the normal version of it.
                switch (selectedNote)
                {
                    case "A":
                        HighlightA();
                        break;

                    case "B":
                        HighlightB();
                        break;

                    case "C":
                        HighlightC();
                        break;

                    case "D":
                        HighlightD();
                        break;

                    case "E":
                        HighlightE();
                        break;

                    case "F":
                        HighlightF();
                        break;

                    case "G":
                        HighlightG();
                        break;
                }

                // Highlight the normal button.
                HighlightNormalButton();
            }

            // If there is no note selected, then reset the note type buttons.
            else
            {
                ChangeBackgroundNoteTypesToDefault();
            }
        }

        // Buttons
        private void Note_A_Octave_Higher_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightA();
        }

        private void Note_G_Octave_Higher_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightG();
        }

        private void Note_F_Octave_Higher_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightF();
        }

        private void Note_E_Octave_Higher_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightE();
        }

        private void Note_D_Octave_Higher_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightD();
        }
        private void Note_C_Octave_Higher_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightC();
        }

        private void Note_B_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightB();
        }

        private void Note_A_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightA();
        }

        private void Note_G_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightG();
        }

        private void Note_F_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightF();
        }

        private void Note_E_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightE();
        }        

        private void Note_D_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightD();
        }

        private void Note_C_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            HighlightC();
        }

        private void Note_Reset_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNotesToDefault();
            ChangeBackgroundNoteTypesToDefault();
            ResetSelectedNote();
        }

        private void Note_Flat_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNoteTypesToDefault();
            MakeFlat();            
        }

        private void Note_Sharp_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNoteTypesToDefault();
            MakeSharp();
        }

        private void Note_Normal_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackgroundFretsBackToDefault();
            ChangeBackgroundNoteTypesToDefault();
            MakeNormal();
        }
    }
}