using TreIRad;


public class BoardCell
    //BoardCell skapar brädet och använder sig av klassen checker för att tilldela X / O på positioner.
{
    Checker checker;
    public BoardCell() { }
    public BoardCell(Checker checker)
    {
        this.setChecker(checker);
    }
    public void setChecker(Checker checker)
    {
        this.checker = checker;
    }
    public char getChecker()
    {
        return checker.GetCheckerSign();
    }
}
public class Checker
    //klassen tilldelar ett tecken med hjälp av konstruktern och instansmetoderna
{
    char checkSign;
    Checker() { }
    public Checker(char checkSign) 
    {
        this.SetChecker(checkSign);
    }
    public void SetChecker(char checkSign)
    {
        this.checkSign = checkSign;
    }
    public char GetCheckerSign()
    {
        return checkSign;
    }
        
}
public class GameBoard
{
    int boardSize;
    BoardCell[,] board;
    GameBoard() { }
    public GameBoard(int boardSize)
    {
        this.SetBoardSize(boardSize);
        this.SetBoard(boardSize);
    }
    public void SetBoardSize(int boardSize)
    {
        this.boardSize = boardSize;
    }
    public int GetBoardSize()
    {
        return this.boardSize;
    }
    public void SetBoard(int boardSize)
    {
        board = new BoardCell[boardSize,boardSize];

        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < board[j]; j++)
            {
                board[i, j] = new BoardCell(new Checker(' '));
            }
        }
    }
    public BoardCell[,] getBoard()
    {
        return this.board;
    }
}