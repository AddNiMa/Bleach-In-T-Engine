using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 奖励信息
 */
public class MillionReward : IMessageSerialize 
{
	//上次奖励项的编号
	int _millionId;	
	//抽奖奖励列表
	List<ItemInfo> _lotteryReward = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//上次奖励项的编号
		SerializeUtils.WriteInt(stream, _millionId);
		//抽奖奖励列表
		SerializeUtils.WriteShort(stream, (short)_lotteryReward.Count);

		foreach (var element in _lotteryReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//上次奖励项的编号
		_millionId = SerializeUtils.ReadInt(stream);
		//抽奖奖励列表
		int _lotteryReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _lotteryReward_length; ++i) 
		{
			_lotteryReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 上次奖励项的编号
	 */
	public int MillionId
	{
		set { _millionId = value; }
	    get { return _millionId; }
	}
	
	/**
	 * get 抽奖奖励列表
	 * @return 
	 */
	public List<ItemInfo> GetLotteryReward()
	{
		return _lotteryReward;
	}
	
	/**
	 * set 抽奖奖励列表
	 */
	public void SetLotteryReward(List<ItemInfo> lotteryReward)
	{
		_lotteryReward = lotteryReward;
	}
	
}