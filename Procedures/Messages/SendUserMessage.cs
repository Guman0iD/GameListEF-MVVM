using Procedures.Model;

namespace Procedures.Messages;

public class SendUserMessage
{
    public Player EnteredPlayer { get; private set; }

    public SendUserMessage(Player enteredPlayer)
    {
        EnteredPlayer = enteredPlayer;
    }
}