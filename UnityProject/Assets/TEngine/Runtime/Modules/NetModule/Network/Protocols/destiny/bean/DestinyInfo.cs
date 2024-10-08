using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 宿命对决信息
 */
public class DestinyInfo : IMessageSerialize 
{
	//角色id
	int _character;	
	//手动通关的最大难度
	int _difficult;	
	//最后一次通关的难度
	int _lastDifficulty;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _character);
		//手动通关的最大难度
		SerializeUtils.WriteInt(stream, _difficult);
		//最后一次通关的难度
		SerializeUtils.WriteInt(stream, _lastDifficulty);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_character = SerializeUtils.ReadInt(stream);
		//手动通关的最大难度
		_difficult = SerializeUtils.ReadInt(stream);
		//最后一次通关的难度
		_lastDifficulty = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int Character
	{
		set { _character = value; }
	    get { return _character; }
	}
	
	/**
	 * 手动通关的最大难度
	 */
	public int Difficult
	{
		set { _difficult = value; }
	    get { return _difficult; }
	}
	
	/**
	 * 最后一次通关的难度
	 */
	public int LastDifficulty
	{
		set { _lastDifficulty = value; }
	    get { return _lastDifficulty; }
	}
	
}