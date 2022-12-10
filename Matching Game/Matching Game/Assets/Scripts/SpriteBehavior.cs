using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
  private SpriteRenderer rendererObj;

  private void Start()
  {
    rendererObj = GetComponent<SpriteRenderer>();
  }
}
