using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 输入GM指令 message
 */
public class ReqPlayerGmMessage : Message 
{
	//GM指令
	string _command;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//GM指令
		SerializeUtils.WriteString(stream, _command);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//GM指令
		_command = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * GM指令
	 */
	public string Command
	{
		set { _command = value; }
	    get { return _command; }
	}
	
	
	public override int GetId() 
	{
		return 105104;
	}
}