using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动是否达成
 */
public class ActivityAwardState : IMessageSerialize 
{
	//条件id
	int _conditionId;	
	//是否已领取奖励 0没领取   1达成 2已领取
	int _state;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//条件id
		SerializeUtils.WriteInt(stream, _conditionId);
		//是否已领取奖励 0没领取   1达成 2已领取
		SerializeUtils.WriteInt(stream, _state);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//条件id
		_conditionId = SerializeUtils.ReadInt(stream);
		//是否已领取奖励 0没领取   1达成 2已领取
		_state = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 条件id
	 */
	public int ConditionId
	{
		set { _conditionId = value; }
	    get { return _conditionId; }
	}
	
	/**
	 * 是否已领取奖励 0没领取   1达成 2已领取
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
}