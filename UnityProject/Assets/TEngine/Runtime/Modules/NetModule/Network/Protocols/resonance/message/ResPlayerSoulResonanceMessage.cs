using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送玩家拥有的魂共鸣技能 message
 */
public class ResPlayerSoulResonanceMessage : Message 
{
	//玩家已拥有的灵魂技能集合
	List<SoulResonance> _soulResonanceList = new List<SoulResonance>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家已拥有的灵魂技能集合
		SerializeUtils.WriteShort(stream, (short)_soulResonanceList.Count);

		foreach (var element in _soulResonanceList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家已拥有的灵魂技能集合
		int _soulResonanceList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulResonanceList_length; ++i) 
		{
			_soulResonanceList.Add(SerializeUtils.ReadBean<SoulResonance>(stream));
		}
	}
	
	/**
	 * get 玩家已拥有的灵魂技能集合
	 * @return 
	 */
	public List<SoulResonance> GetSoulResonanceList()
	{
		return _soulResonanceList;
	}
	
	/**
	 * set 玩家已拥有的灵魂技能集合
	 */
	public void SetSoulResonanceList(List<SoulResonance> soulResonanceList)
	{
		_soulResonanceList = soulResonanceList;
	}
	
	
	public override int GetId() 
	{
		return 111101;
	}
}