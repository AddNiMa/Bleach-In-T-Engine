using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 登录活动奖励信息
 */
public class ActivityAwardBean : IMessageSerialize 
{
	//条件id 这个id是 一个key 来源于条件值 或数组第一位  
	int _id;	
	//是否已领取奖励 0没领取   1达成 2已领取
	int _state;	
	//客户端奖励消息
	string _awardDesc;	
	//条件集合
	List<ActivityAwardCondition> _conditios = new List<ActivityAwardCondition>();
	//物品
	List<ItemInfo> _itemInfo = new List<ItemInfo>();
	//进度需求值
	int _progress;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//条件id 这个id是 一个key 来源于条件值 或数组第一位  
		SerializeUtils.WriteInt(stream, _id);
		//是否已领取奖励 0没领取   1达成 2已领取
		SerializeUtils.WriteInt(stream, _state);
		//客户端奖励消息
		SerializeUtils.WriteString(stream, _awardDesc);
		//条件集合
		SerializeUtils.WriteShort(stream, (short)_conditios.Count);

		foreach (var element in _conditios)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//物品
		SerializeUtils.WriteShort(stream, (short)_itemInfo.Count);

		foreach (var element in _itemInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//进度需求值
		SerializeUtils.WriteInt(stream, _progress);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//条件id 这个id是 一个key 来源于条件值 或数组第一位  
		_id = SerializeUtils.ReadInt(stream);
		//是否已领取奖励 0没领取   1达成 2已领取
		_state = SerializeUtils.ReadInt(stream);
		//客户端奖励消息
		_awardDesc = SerializeUtils.ReadString(stream);
		//条件集合
		int _conditios_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _conditios_length; ++i) 
		{
			_conditios.Add(SerializeUtils.ReadBean<ActivityAwardCondition>(stream));
		}
		//物品
		int _itemInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _itemInfo_length; ++i) 
		{
			_itemInfo.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//进度需求值
		_progress = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 条件id 这个id是 一个key 来源于条件值 或数组第一位  
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 是否已领取奖励 0没领取   1达成 2已领取
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * 客户端奖励消息
	 */
	public string AwardDesc
	{
		set { _awardDesc = value; }
	    get { return _awardDesc; }
	}
	
	/**
	 * get 条件集合
	 * @return 
	 */
	public List<ActivityAwardCondition> GetConditios()
	{
		return _conditios;
	}
	
	/**
	 * set 条件集合
	 */
	public void SetConditios(List<ActivityAwardCondition> conditios)
	{
		_conditios = conditios;
	}
	
	/**
	 * get 物品
	 * @return 
	 */
	public List<ItemInfo> GetItemInfo()
	{
		return _itemInfo;
	}
	
	/**
	 * set 物品
	 */
	public void SetItemInfo(List<ItemInfo> itemInfo)
	{
		_itemInfo = itemInfo;
	}
	
	/**
	 * 进度需求值
	 */
	public int Progress
	{
		set { _progress = value; }
	    get { return _progress; }
	}
	
}