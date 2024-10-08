using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取妹子的面板 message
 */
public class ResGirlGetInfoMessage : Message 
{
	//当前已经达到的条件
	List<GirlGetConditionInfo> _infos = new List<GirlGetConditionInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前已经达到的条件
		SerializeUtils.WriteShort(stream, (short)_infos.Count);

		foreach (var element in _infos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前已经达到的条件
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<GirlGetConditionInfo>(stream));
		}
	}
	
	/**
	 * get 当前已经达到的条件
	 * @return 
	 */
	public List<GirlGetConditionInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 当前已经达到的条件
	 */
	public void SetInfos(List<GirlGetConditionInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 108104;
	}
}