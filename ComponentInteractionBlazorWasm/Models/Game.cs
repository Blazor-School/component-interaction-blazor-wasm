namespace ComponentInteractionBlazorWasm.Models
{
    public class Game
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnNameChanged?.Invoke(this, value);
            }
        }

        public delegate void OnNameChangedHandler(object sender, string name);
        public event OnNameChangedHandler OnNameChanged;
    }
}
