using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 极限挑战结束战斗回复 message
 */
public class ResEndUnlimitFightBattleMessage : Message 
{
	//极限挑战战斗是否成功[0:挑战成功,1:挑战失败]
	int _result;	
	//基础奖励列表
	List<ItemInfo> _baseRewardInfos = new List<ItemInfo>();
	//特殊奖励列表
	List<ItemInfo> _specialRewardInfos = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//极限挑战战斗是否成功[0:挑战成功,1:挑战失败]
		SerializeUtils.WriteInt(stream, _result);
		//基础奖励列表
		SerializeUtils.WriteShort(stream, (short)_baseRewardInfos.Count);

		foreach (var element in _baseRewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//特殊奖励列表
		SerializeUtils.WriteShort(stream, (short)_specialRewardInfos.Count);

		foreach (var element in _specialRewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//极限挑战战斗是否成功[0:挑战成功,1:挑战失败]
		_result = SerializeUtils.ReadInt(stream);
		//基础奖励列表
		int _baseRewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _baseRewardInfos_length; ++i) 
		{
			_baseRewardInfos.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//特殊奖励列表
		int _specialRewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _specialRewardInfos_length; ++i) 
		{
			_specialRewardInfos.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 极限挑战战斗是否成功[0:挑战成功,1:挑战失败]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 基础奖励列表
	 * @return 
	 */
	public List<ItemInfo> GetBaseRewardInfos()
	{
		return _baseRewardInfos;
	}
	
	/**
	 * set 基础奖励列表
	 */
	public void SetBaseRewardInfos(List<ItemInfo> baseRewardInfos)
	{
		_baseRewardInfos = baseRewardInfos;
	}
	
	/**
	 * get 特殊奖励列表
	 * @return 
	 */
	public List<ItemInfo> GetSpecialRewardInfos()
	{
		return _specialRewardInfos;
	}
	
	/**
	 * set 特殊奖励列表
	 */
	public void SetSpecialRewardInfos(List<ItemInfo> specialRewardInfos)
	{
		_specialRewardInfos = specialRewardInfos;
	}
	
	
	public override int GetId() 
	{
		return 221104;
	}
}