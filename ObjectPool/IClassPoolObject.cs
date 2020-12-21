﻿using UnityEngine;

namespace BiangLibrary.ObjectPool
{
    public interface IClassPoolObject<T>
    {
        T Create();
        void OnUsed();
        void OnRelease();
        void SetPoolIndex(int index);
        int GetPoolIndex();
    }
}