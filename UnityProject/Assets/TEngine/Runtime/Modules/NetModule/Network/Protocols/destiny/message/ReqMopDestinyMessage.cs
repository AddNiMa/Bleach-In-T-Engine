using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求扫荡宿命对决信息 message
 */
public class ReqMopDestinyMessage : Message 
{
	//对决表索引id
	int _index;	
	//使用角色
	int _character;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对决表索引id
		SerializeUtils.WriteInt(stream, _index);
		//使用角色
		SerializeUtils.WriteInt(stream, _character);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对决表索引id
		_index = SerializeUtils.ReadInt(stream);
		//使用角色
		_character = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 对决表索引id
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	/**
	 * 使用角色
	 */
	public int Character
	{
		set { _character = value; }
	    get { return _character; }
	}
	
	
	public override int GetId() 
	{
		return 107205;
	}
}