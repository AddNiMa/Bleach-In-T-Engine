using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应请求扫荡宿命对决信息 message
 */
public class ResMopDestinyMessage : Message 
{
	//扫荡结果[0:成功 ,1:宿命对决未开启,2:难度错误 ,3:体力不够,4:等级不够,5:今日已挑战,6:还没有手动通过该难度,7:玩家没有该出战角色,8:对应编号的宿命对决不存在,9:出战角色和配置表里面配置的角色不一致,10:玩家不可以参加该宿命对决]
	int _result;	
	//宿命对决扫荡奖励列表
	List<MopReward> _destinyMopReward = new List<MopReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//扫荡结果[0:成功 ,1:宿命对决未开启,2:难度错误 ,3:体力不够,4:等级不够,5:今日已挑战,6:还没有手动通过该难度,7:玩家没有该出战角色,8:对应编号的宿命对决不存在,9:出战角色和配置表里面配置的角色不一致,10:玩家不可以参加该宿命对决]
		SerializeUtils.WriteInt(stream, _result);
		//宿命对决扫荡奖励列表
		SerializeUtils.WriteShort(stream, (short)_destinyMopReward.Count);

		foreach (var element in _destinyMopReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//扫荡结果[0:成功 ,1:宿命对决未开启,2:难度错误 ,3:体力不够,4:等级不够,5:今日已挑战,6:还没有手动通过该难度,7:玩家没有该出战角色,8:对应编号的宿命对决不存在,9:出战角色和配置表里面配置的角色不一致,10:玩家不可以参加该宿命对决]
		_result = SerializeUtils.ReadInt(stream);
		//宿命对决扫荡奖励列表
		int _destinyMopReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _destinyMopReward_length; ++i) 
		{
			_destinyMopReward.Add(SerializeUtils.ReadBean<MopReward>(stream));
		}
	}
	
	/**
	 * 扫荡结果[0:成功 ,1:宿命对决未开启,2:难度错误 ,3:体力不够,4:等级不够,5:今日已挑战,6:还没有手动通过该难度,7:玩家没有该出战角色,8:对应编号的宿命对决不存在,9:出战角色和配置表里面配置的角色不一致,10:玩家不可以参加该宿命对决]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 宿命对决扫荡奖励列表
	 * @return 
	 */
	public List<MopReward> GetDestinyMopReward()
	{
		return _destinyMopReward;
	}
	
	/**
	 * set 宿命对决扫荡奖励列表
	 */
	public void SetDestinyMopReward(List<MopReward> destinyMopReward)
	{
		_destinyMopReward = destinyMopReward;
	}
	
	
	public override int GetId() 
	{
		return 107105;
	}
}