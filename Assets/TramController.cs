using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TramController : MonoBehaviour
{
    private enum Direction { left, right };
    private Direction turn = Direction.right;
    private GForce[] gforceAffected;

    [SerializeField] UnityEvent<bool> warningEvent;
    [SerializeField] TextMeshProUGUI warningText;

    [SerializeField] readonly float warningDelay = 2.5f;
    [SerializeField] readonly float force = 3f;

    private void Start()
    {
        gforceAffected = FindObjectsOfType<GForce>();

        RandomTurn();
    }

    private void RandomTurn()
    {
        int randomIndex = Random.Range(0, System.Enum.GetNames(typeof(Direction)).Length);
        turn = (Direction)randomIndex;

        int turnDelay = Random.Range(5, 10);

        Invoke(nameof(SharpTurnWarning), turnDelay);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TurnDone();
            turn = Direction.right;
            SharpTurnWarning();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            TurnDone();
            turn = Direction.left;
            SharpTurnWarning();
        }
    }

    public void SharpTurnWarning()
    {
        warningText.text = "SHARP TURN!\r\n" + turn.ToString().ToUpper();
        warningEvent.Invoke(true);

        Invoke(nameof(TurnTram), warningDelay);
    }

    public void TurnTram()
    {
        Debug.Log(turn);
        foreach (GForce affected in gforceAffected)
        {
            affected.Push(turn == Direction.right ? Vector2.right : Vector2.left, force);
        }

        Invoke(nameof(TurnDone), warningDelay);
    }

    private void TurnDone()
    {
        warningEvent.Invoke(false);
        RandomTurn();
    }
}
//TODO: ADD 5-15 sec cooldown for turns, and perspective Bool