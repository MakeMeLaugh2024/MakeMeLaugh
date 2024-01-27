using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public interface IBuffUser {

	float MoveDirectionFactor { get; set; }
	float GravityScaleFactor { get; set; }
	float JumpForceFactor { get; set; }
	float MoveSpeedFactor { get; set; }
	bool CanMoveFlag { get; set; }
	

	void RemoveBuff(IBuff buff);
	void ApplyBuff(IBuff buff);

	// 重力因子发生变化，调用此函数
	void GravityScaleHook();
}