using System.Collections.ObjectModel;
using System.Windows;

namespace Heartswitch
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }

    public class MainWindowViewModel
    {
        public ObservableCollection<Card> Player1Hand { get; set; }
        public ObservableCollection<Card> Player2Hand { get; set; }
        public ObservableCollection<Card> Player3Hand { get; set; }
        public ObservableCollection<Card> Player4Hand { get; set; }

        public MainWindowViewModel()
        {
            // Example cards for testing
            Player1Hand = new ObservableCollection<Card>
            {
                new Card { Rank = "A", Suit = "♥" },
                new Card { Rank = "2", Suit = "♠" },
                new Card { Rank = "K", Suit = "♦" }
            };

            Player2Hand = new ObservableCollection<Card>
            {
                new Card { Rank = "Q", Suit = "♥" },
                new Card { Rank = "4", Suit = "♠" },
                new Card { Rank = "9", Suit = "♦" }
            };

            Player3Hand = new ObservableCollection<Card>
            {
                new Card { Rank = "2", Suit = "♥" },
                new Card { Rank = "8", Suit = "♠" },
                new Card { Rank = "6", Suit = "♦" }
            };

            Player4Hand = new ObservableCollection<Card>
            {
                new Card { Rank = "J", Suit = "♥" },
                new Card { Rank = "10", Suit = "♠" },
                new Card { Rank = "9", Suit = "♦" }
            };
        }
    }

    public class Card
    {
        public string Rank { get; set; } // e.g., "A", "2", "K"
        public string Suit { get; set; } // e.g., "♥", "♠", "♦", "♣"
    }
}
