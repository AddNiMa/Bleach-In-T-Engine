using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更新宿命对决剩余次数 message
 */
public class ResDestinyUsedCountMessage : Message 
{
	//宿命对决剩余次数
	int _usedCount;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//宿命对决剩余次数
		SerializeUtils.WriteInt(stream, _usedCount);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//宿命对决剩余次数
		_usedCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 宿命对决剩余次数
	 */
	public int UsedCount
	{
		set { _usedCount = value; }
	    get { return _usedCount; }
	}
	
	
	public override int GetId() 
	{
		return 107104;
	}
}