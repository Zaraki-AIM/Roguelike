using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;
using Common;
using Status.Messaging;
using Status.Views;

public class StatusController : MonoBehaviour
{
  [SerializeField]
  private CommonTextView _HP;
  [SerializeField]
  private LevelView _Level;
  [SerializeField]
  private CommonTextView _Exp;
  [SerializeField]
  private CommonTextView _Satiety;

  [Inject]
  private StatusMessageBroker _StatusMessageBroker;

  private void Awake()
  {
    SubscribeOutsideEvent();
  }

  private void Start()
  {
    _StatusMessageBroker.Publish(new LevelChange(2));
  }

  private void SubscribeOutsideEvent()
  {
    _StatusMessageBroker.Receive<LevelChange>()
    .Subscribe(_ => LevelChange(_.IncrementOfLevel))
    .AddTo(this);
  }

  private void LevelChange(int incrementOfLevel)
  {
    _Level.SetText(incrementOfLevel.ToString());
  }
}
