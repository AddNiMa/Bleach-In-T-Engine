using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应抽奖消息 message
 */
public class ResMillionLotteryMessage : Message 
{
	//结果[0:成功,1,不在系统开放时间内2:功能未开放,3:魂玉不足]
	int _result;	
	//抽奖类型[0:抽奖1次,1:抽奖10次]
	int _type;	
	//是否是闪烁事件[0:不是闪烁事件,大于0:是闪烁事件]
	int _specialPos;	
	//奖励列表
	List<MillionReward> _millionReward = new List<MillionReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1,不在系统开放时间内2:功能未开放,3:魂玉不足]
		SerializeUtils.WriteInt(stream, _result);
		//抽奖类型[0:抽奖1次,1:抽奖10次]
		SerializeUtils.WriteInt(stream, _type);
		//是否是闪烁事件[0:不是闪烁事件,大于0:是闪烁事件]
		SerializeUtils.WriteInt(stream, _specialPos);
		//奖励列表
		SerializeUtils.WriteShort(stream, (short)_millionReward.Count);

		foreach (var element in _millionReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果[0:成功,1,不在系统开放时间内2:功能未开放,3:魂玉不足]
		_result = SerializeUtils.ReadInt(stream);
		//抽奖类型[0:抽奖1次,1:抽奖10次]
		_type = SerializeUtils.ReadInt(stream);
		//是否是闪烁事件[0:不是闪烁事件,大于0:是闪烁事件]
		_specialPos = SerializeUtils.ReadInt(stream);
		//奖励列表
		int _millionReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _millionReward_length; ++i) 
		{
			_millionReward.Add(SerializeUtils.ReadBean<MillionReward>(stream));
		}
	}
	
	/**
	 * 结果[0:成功,1,不在系统开放时间内2:功能未开放,3:魂玉不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 抽奖类型[0:抽奖1次,1:抽奖10次]
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 是否是闪烁事件[0:不是闪烁事件,大于0:是闪烁事件]
	 */
	public int SpecialPos
	{
		set { _specialPos = value; }
	    get { return _specialPos; }
	}
	
	/**
	 * get 奖励列表
	 * @return 
	 */
	public List<MillionReward> GetMillionReward()
	{
		return _millionReward;
	}
	
	/**
	 * set 奖励列表
	 */
	public void SetMillionReward(List<MillionReward> millionReward)
	{
		_millionReward = millionReward;
	}
	
	
	public override int GetId() 
	{
		return 316101;
	}
}