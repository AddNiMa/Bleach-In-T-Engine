using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 极限挑战信息[列表] message
 */
public class ResUnlimitFightInfosMessage : Message 
{
	//极限挑战信息列表
	List<UnlimitFightBaseInfo> _unlimitFightBaseInfos = new List<UnlimitFightBaseInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//极限挑战信息列表
		SerializeUtils.WriteShort(stream, (short)_unlimitFightBaseInfos.Count);

		foreach (var element in _unlimitFightBaseInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//极限挑战信息列表
		int _unlimitFightBaseInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _unlimitFightBaseInfos_length; ++i) 
		{
			_unlimitFightBaseInfos.Add(SerializeUtils.ReadBean<UnlimitFightBaseInfo>(stream));
		}
	}
	
	/**
	 * get 极限挑战信息列表
	 * @return 
	 */
	public List<UnlimitFightBaseInfo> GetUnlimitFightBaseInfos()
	{
		return _unlimitFightBaseInfos;
	}
	
	/**
	 * set 极限挑战信息列表
	 */
	public void SetUnlimitFightBaseInfos(List<UnlimitFightBaseInfo> unlimitFightBaseInfos)
	{
		_unlimitFightBaseInfos = unlimitFightBaseInfos;
	}
	
	
	public override int GetId() 
	{
		return 221102;
	}
}