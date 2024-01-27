using System.Collections.Generic;

public interface IBuffUser {
	public float MoveDirectionFactor { get; set; }
	public float GravityScaleFactor { get; set; }
	public float JumpForceFactor { get; set; }
	public bool CanMoveFlag { get; set; }

	public void RemoveBuff(IBuff buff);
	public void ApplyBuff(IBuff buff);	
}