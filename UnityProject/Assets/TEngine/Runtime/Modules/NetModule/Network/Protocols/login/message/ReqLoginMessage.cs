using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 登陆 message
 */
public class ReqLoginMessage : Message 
{
	//玩家用户名
	string _name;	
	//玩家密码
	string _password;	
	//服务器Id
	int _serverId;	
	//消息数量
	int _msgCount;	
	//游戏版本号
	int _gameVersion;	
	//手机硬件信息
	string _phoneInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家用户名
		SerializeUtils.WriteString(stream, _name);
		//玩家密码
		SerializeUtils.WriteString(stream, _password);
		//服务器Id
		SerializeUtils.WriteInt(stream, _serverId);
		//消息数量
		SerializeUtils.WriteInt(stream, _msgCount);
		//游戏版本号
		SerializeUtils.WriteInt(stream, _gameVersion);
		//手机硬件信息
		SerializeUtils.WriteString(stream, _phoneInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家用户名
		_name = SerializeUtils.ReadString(stream);
		//玩家密码
		_password = SerializeUtils.ReadString(stream);
		//服务器Id
		_serverId = SerializeUtils.ReadInt(stream);
		//消息数量
		_msgCount = SerializeUtils.ReadInt(stream);
		//游戏版本号
		_gameVersion = SerializeUtils.ReadInt(stream);
		//手机硬件信息
		_phoneInfo = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 玩家用户名
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * 玩家密码
	 */
	public string Password
	{
		set { _password = value; }
	    get { return _password; }
	}
	
	/**
	 * 服务器Id
	 */
	public int ServerId
	{
		set { _serverId = value; }
	    get { return _serverId; }
	}
	
	/**
	 * 消息数量
	 */
	public int MsgCount
	{
		set { _msgCount = value; }
	    get { return _msgCount; }
	}
	
	/**
	 * 游戏版本号
	 */
	public int GameVersion
	{
		set { _gameVersion = value; }
	    get { return _gameVersion; }
	}
	
	/**
	 * 手机硬件信息
	 */
	public string PhoneInfo
	{
		set { _phoneInfo = value; }
	    get { return _phoneInfo; }
	}
	
	
	public override int GetId() 
	{
		return 100201;
	}
}