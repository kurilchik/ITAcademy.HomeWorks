namespace AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeedPublic = 300;
        protected internal const ushort MaxSpeedProtectedInternal = 300;
        internal const ushort MaxSpeedInternal = 300;
        protected const ushort MaxSpeedProtected = 300;
        private protected const ushort MaxSpeedPrivateProtected = 300;
        private const ushort MaxSpeedPrivate = 300;


        public int _vinNumberPublic;
        protected internal int _vinNumberProtectedInternal;
        internal int _vinNumberInternal;
        protected int _vinNumberProtected;
        private protected int _vinNumberPrivateProtected;
        private int _vinNumberPrivate;


        public string ModelPublic { get; set; }

        protected internal string ModelProtectedInternal { get; set; }

        internal string ModelInternal { get; set; }

        protected string ModelProtected { get; set; }

        private protected string ModelPrivateProtected { get; set; }

        private string ModelPrivate { get; set; }


        public void StartEnginePublic()
        {
        }

        protected internal void StartEngineProtectedInternal()
        {
        }

        internal void StartEngineInternal()
        {
        }

        protected void StartEngineProtected()
        {
        }

        private protected void StartEnginePrivateProtrcted()
        {
        }

        private void StartEnginePrivate()
        {
        }
    }
}
