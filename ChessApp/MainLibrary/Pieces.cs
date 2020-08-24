namespace MainLibrary
{
    public class Pieces
    {
        private readonly Queen queen;
        private readonly Pawn pawn;
        private readonly Bishop bishop;
        private readonly Knight knight;
        private readonly Rook rook;
        private readonly King king;
        public Pieces()
        {
            pawn = new Pawn();
            bishop = new Bishop();
            knight = new Knight();
            king = new King();
            rook = new Rook();
            queen = new Queen();
        }
    }
}