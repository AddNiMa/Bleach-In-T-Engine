using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动目标达成 message
 */
public class ResActivityTriggerMessage : Message 
{
	//活动目标集合
	List<ActivityTriggerBean> _triggerList = new List<ActivityTriggerBean>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动目标集合
		SerializeUtils.WriteShort(stream, (short)_triggerList.Count);

		foreach (var element in _triggerList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动目标集合
		int _triggerList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _triggerList_length; ++i) 
		{
			_triggerList.Add(SerializeUtils.ReadBean<ActivityTriggerBean>(stream));
		}
	}
	
	/**
	 * get 活动目标集合
	 * @return 
	 */
	public List<ActivityTriggerBean> GetTriggerList()
	{
		return _triggerList;
	}
	
	/**
	 * set 活动目标集合
	 */
	public void SetTriggerList(List<ActivityTriggerBean> triggerList)
	{
		_triggerList = triggerList;
	}
	
	
	public override int GetId() 
	{
		return 311106;
	}
}