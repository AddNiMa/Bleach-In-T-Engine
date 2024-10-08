using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * gm告诉玩家 message
 */
public class ResGmSuggestToPlayerMessage : Message 
{
	//要说的话
	string _context;	
	//冷却时间
	int _cdTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//要说的话
		SerializeUtils.WriteString(stream, _context);
		//冷却时间
		SerializeUtils.WriteInt(stream, _cdTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//要说的话
		_context = SerializeUtils.ReadString(stream);
		//冷却时间
		_cdTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 要说的话
	 */
	public string Context
	{
		set { _context = value; }
	    get { return _context; }
	}
	
	/**
	 * 冷却时间
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
	
	public override int GetId() 
	{
		return 105111;
	}
}