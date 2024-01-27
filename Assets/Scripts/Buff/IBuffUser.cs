using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public interface IBuffUser {

	float MoveDirectionFactor { get; set; }
	float GravityScaleFactor { get; set; }
	float JumpForceFactor { get; set; }
	float MoveSpeedFactor { get; set; }
	bool CanMoveFlag { get; set; }
	bool IsSlippery { get; set; }

    void RemoveBuff(IBuff buff);
	void ApplyBuff(IBuff buff);

	// 重力钩子
	void GravityScaleHook();
	// 打滑钩子
	void SlipperyHook();
}