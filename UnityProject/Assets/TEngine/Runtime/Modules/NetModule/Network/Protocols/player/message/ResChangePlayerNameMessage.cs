using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家改名回复 message
 */
public class ResChangePlayerNameMessage : Message 
{
	//0-成功，1-名字重复，2-名字不合法
	int _result;	
	//新名字
	string _name;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-成功，1-名字重复，2-名字不合法
		SerializeUtils.WriteInt(stream, _result);
		//新名字
		SerializeUtils.WriteString(stream, _name);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-成功，1-名字重复，2-名字不合法
		_result = SerializeUtils.ReadInt(stream);
		//新名字
		_name = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 0-成功，1-名字重复，2-名字不合法
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 新名字
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	
	public override int GetId() 
	{
		return 105112;
	}
}