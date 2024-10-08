using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取登录奖励 message
 */
public class ReqActivityRewardMessage : Message 
{
	//活动id
	int _activityId;	
	//领取哪个条件的 奖励
	int _conditionId;	
	//0-单次兑换 1-多次兑换
	int _rewardType;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动id
		SerializeUtils.WriteInt(stream, _activityId);
		//领取哪个条件的 奖励
		SerializeUtils.WriteInt(stream, _conditionId);
		//0-单次兑换 1-多次兑换
		SerializeUtils.WriteInt(stream, _rewardType);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动id
		_activityId = SerializeUtils.ReadInt(stream);
		//领取哪个条件的 奖励
		_conditionId = SerializeUtils.ReadInt(stream);
		//0-单次兑换 1-多次兑换
		_rewardType = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 活动id
	 */
	public int ActivityId
	{
		set { _activityId = value; }
	    get { return _activityId; }
	}
	
	/**
	 * 领取哪个条件的 奖励
	 */
	public int ConditionId
	{
		set { _conditionId = value; }
	    get { return _conditionId; }
	}
	
	/**
	 * 0-单次兑换 1-多次兑换
	 */
	public int RewardType
	{
		set { _rewardType = value; }
	    get { return _rewardType; }
	}
	
	
	public override int GetId() 
	{
		return 311202;
	}
}