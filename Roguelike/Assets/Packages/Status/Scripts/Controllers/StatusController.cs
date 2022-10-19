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
  private HPView _HP;
  [SerializeField]
  private LevelView _Level;
  // [SerializeField]
  // private CommonTextView _Exp;
  [SerializeField]
  private SatietyView _Satiety;

  [Inject]
  private StatusMessageBroker _StatusMessageBroker;

  private void Awake()
  {
    SubscribeOutsideEvent();
  }

  private void Start()
  {
    _StatusMessageBroker.Publish(new LevelChange(2));
    _StatusMessageBroker.Publish(new HPChange(2,10));
    _StatusMessageBroker.Publish(new SatietyChange(99));
  }

  private void SubscribeOutsideEvent()
  {
    _StatusMessageBroker.Receive<LevelChange>()
    .Subscribe(_ => LevelChange(_.IncrementOfLevel))
    .AddTo(this);
     _StatusMessageBroker.Receive<HPChange>()
    .Subscribe(_ => HPChange(_.IncrementOfHP,_.MaxHP))
    .AddTo(this);
     _StatusMessageBroker.Receive<SatietyChange>()
    .Subscribe(_ => SatietyChange(_.IncrementOfSatiety))
    .AddTo(this);
  }

  private void LevelChange(int incrementOfLevel)
  {
    _Level.SetLevel(incrementOfLevel);
  }

  private void HPChange(int incrementOfHP,int maxHP)
  {
    _HP.SetHP(incrementOfHP,maxHP);
  }

  private void SatietyChange(int incrementOfSatiety)
  {
    _Satiety.SetSatiety(incrementOfSatiety);
  }
}
