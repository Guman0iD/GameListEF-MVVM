using Procedures.Model;

namespace Procedures.Messages;

public class SendAccountMessage
{
    public Account EnteredPlayer { get; private set; }

    public SendAccountMessage(Account enteredPlayer)
    {
        EnteredPlayer = enteredPlayer;
    }
}       