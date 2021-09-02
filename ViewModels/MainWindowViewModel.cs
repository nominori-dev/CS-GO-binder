using csgoBinder.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace csgoBinder.ViewModels
{

    public class Actions
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class Buttons
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class Commands
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    class MainWindowViewModel : ViewModelBase
    {

        private string _config;
        private int _selectedIndex;
        

        public int selectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged();
            }
        }

        public string config
        {
            get { return _config; }
            set
            {
                _config = value;
                OnPropertyChanged();
            }
        }
        private string action;


        public ICommand addAction { get; set; }
        public ICommand addCommand { get; set; }
        public ICommand saveCfg { get; set; }
        public ICommand clearConfig { get; set; }

        private ObservableCollection<Actions> _actions;
        private ObservableCollection<Buttons> _buttons;
        private ObservableCollection<Commands> _commands;


        public ObservableCollection<Actions> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        public ObservableCollection<Buttons> Buttons
        {
            get { return _buttons; }
            set { _buttons = value; }
        }

        public ObservableCollection<Commands> Commands
        {
            get { return _commands; }
            set { _commands = value; }
        }

        private Actions _sactions;
        private Buttons _sbuttons;
        private Commands _scommands;
        

        public Actions SActions
        {
            get { return _sactions; }
            set { _sactions = value; }
        }

        public Buttons SButtons
        {
            get { return _sbuttons; }
            set { _sbuttons = value; }
        }

        public Commands SCommands
        {
            get { return _scommands; }
            set { _scommands = value; }
        }

        public MainWindowViewModel()
        {
            Actions = new ObservableCollection<Actions>()
            {
                new Actions(){Id=1, Name="Jumpthrow"},
                new Actions(){Id=2, Name="Mousewheel Jump"},
                new Actions(){Id=3, Name="Quickswitch"},
                new Actions(){Id=4, Name="Flashbang"},
                new Actions(){Id=5, Name="Smoke"},
                new Actions(){Id=6, Name="HE grenade"},
                new Actions(){Id=7, Name="Molotov"},
                new Actions(){Id=8, Name="Drop bomb"},
                new Actions(){Id=9, Name="Clear Decals"},
                new Actions(){Id=10, Name="Switch Hands"},
                new Actions(){Id=11, Name="Remove Crosshair"}
            };

            SActions = Actions[0];

            Buttons = new ObservableCollection<Buttons>()
            {
                new Buttons(){Id=1, Name="f1"},
                new Buttons(){Id=2, Name="f2"},
                new Buttons(){Id=3, Name="f3"},
                new Buttons(){Id=4, Name="f4"},
                new Buttons(){Id=5, Name="f5"},
                new Buttons(){Id=6, Name="f6"},
                new Buttons(){Id=7, Name="f7"},
                new Buttons(){Id=8, Name="f8"},
                new Buttons(){Id=9, Name="f9"},
                new Buttons(){Id=10, Name="f10"},
                new Buttons(){Id=12, Name="f11"},
                new Buttons(){Id=13, Name="f12"},
                new Buttons(){Id=14, Name="1"},
                new Buttons(){Id=15, Name="2"},
                new Buttons(){Id=16, Name="3"},
                new Buttons(){Id=17, Name="4"},
                new Buttons(){Id=18, Name="5"},
                new Buttons(){Id=19, Name="A"},
                new Buttons(){Id=20, Name="B"},
                new Buttons(){Id=21, Name="C"},
                new Buttons(){Id=22, Name="D"},
                new Buttons(){Id=23, Name="E"},
                new Buttons(){Id=24, Name="G"},
                new Buttons(){Id=25, Name="H"},
                new Buttons(){Id=26, Name="L"},
                new Buttons(){Id=27, Name="J"},
                new Buttons(){Id=28, Name="K"},
                new Buttons(){Id=29, Name="M"},
                new Buttons(){Id=30, Name="N"},
                new Buttons(){Id=31, Name="O"},
                new Buttons(){Id=32, Name="P"},
                new Buttons(){Id=33, Name="Q"},
                new Buttons(){Id=34, Name="R"},
                new Buttons(){Id=35, Name="S"},
                new Buttons(){Id=36, Name="T"},
                new Buttons(){Id=37, Name="U"},
                new Buttons(){Id=38, Name="V"},
                new Buttons(){Id=39, Name="W"},
                new Buttons(){Id=40, Name="X"},
                new Buttons(){Id=41, Name="Y"},
                new Buttons(){Id=42, Name="Z"},

            };

            SButtons = Buttons[0];

            Commands = new ObservableCollection<Commands>()
            {
                new Commands(){Id=1, Name="-freq 144"},
                new Commands(){Id=2, Name="-freq 75"},
                new Commands(){Id=3, Name="-refresh 144"},
                new Commands(){Id=4, Name="+break"},
                new Commands(){Id=5, Name="+jump"},
                new Commands(){Id=6, Name="+lookdown"},
                new Commands(){Id=7, Name="+reload"},
            };

            SCommands = Commands[0];

            addAction = new DelegateCommand(AddActionWithButton, returnTrue);
            addCommand = new DelegateCommand(AddCommand, returnTrue);
            saveCfg = new DelegateCommand(SaveConfigFile, returnTrue);
            clearConfig = new DelegateCommand(ClearConfigBox, returnTrue);
        }

        private void AddCommand(object value)
        {
            config += SCommands.Name;
        }

        private void ClearConfigBox(object value)
        {
            config = String.Empty;
        }

        private void SaveConfigFile(object value)
        {
            var writer = new StreamWriter(File.OpenWrite("config.cfg"));
            writer.WriteLine(config);
            writer.Close();
            MessageBox.Show("Successfuly saved to config.cfg");
        }

        private void AddActionWithButton(object value)
        {
            try
            {
                if(SActions.Name == null || SActions.Name.Equals(String.Empty))
                {
                    MessageBox.Show("Please select action or button before adding!");
                }
                else
                {
                    string actionbox = SActions.Name;
                    string buttonbox = SButtons.Name;
                    string first = null;
                    string second = null;
                    switch (actionbox)
                    {
                        case "Jumpthrow":
                            first = $"alias \" + jumpthrow\" \" + jump; -attack\"; alias \" - jumpthrow\" \" - jump\"\nbind {buttonbox} \"+jumpthrow\"";
                            break;
                        case "Mousewheel Jump":
                            first = $"bind mwheelup +jump;bind mwheeldown +jump;bind space +jump";
                            break;
                        case "Quickswitch":
                            first = $"bind {buttonbox} \"use weapon_knife;slo1\"";
                            break;
                        case "Flashbang":
                            first = $"bind {buttonbox} \"use weapon_flashbang\"";
                            break;
                        case "Smoke":
                            first = $"bind {buttonbox} \"use weapon_smokegrenade\"";
                            break;
                        case "HE grenade":
                            first = $"bind {buttonbox} \"use weapon_hegrenade\"";
                            break;
                        case "Molotov":
                            first = $"bind {buttonbox} \"use weapon_molotov;use weapon_incgrenade\"";
                            break;
                        case "Drop Bomb":
                            first = $"bind {buttonbox} \"use weapon_knife; use weapon_c4; drop; slot1\"";
                            break;
                        case "Clear Decals":
                            first = $"bind {buttonbox} \"r_cleardecals\"";
                            break;
                        case "Switch Hands":
                            first = $"bind {buttonbox} \"toggle cl_righthand 0 1\"";
                            break;
                        case "Remove Crosshair":
                            first = $"bind {buttonbox} \"toggle crosshair 0 1\"";
                            break;
                        default:
                            break;
                    }
                    string str = first + "\n";

                    config += str;
                }

            }
            catch
            {
                MessageBox.Show("Please select action or button before adding!");
            }

        }


        private bool returnTrue(object value)
        {
            return true;
        }



    }
}
