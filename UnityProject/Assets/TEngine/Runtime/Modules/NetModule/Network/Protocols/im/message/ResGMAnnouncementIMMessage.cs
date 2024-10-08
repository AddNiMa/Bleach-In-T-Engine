using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端收到gm发送的公告消息 message
 */
public class ResGMAnnouncementIMMessage : Message 
{
	//世界消息内容
	string _content;	
	//是否滚屏显示（否：0；是：1）
	int _socroll;	
	//是否显示叹号（否：0；是：1）
	int _prompting;	
	//优先级(1到99)
	int _priority;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//世界消息内容
		SerializeUtils.WriteString(stream, _content);
		//是否滚屏显示（否：0；是：1）
		SerializeUtils.WriteInt(stream, _socroll);
		//是否显示叹号（否：0；是：1）
		SerializeUtils.WriteInt(stream, _prompting);
		//优先级(1到99)
		SerializeUtils.WriteInt(stream, _priority);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//世界消息内容
		_content = SerializeUtils.ReadString(stream);
		//是否滚屏显示（否：0；是：1）
		_socroll = SerializeUtils.ReadInt(stream);
		//是否显示叹号（否：0；是：1）
		_prompting = SerializeUtils.ReadInt(stream);
		//优先级(1到99)
		_priority = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 世界消息内容
	 */
	public string Content
	{
		set { _content = value; }
	    get { return _content; }
	}
	
	/**
	 * 是否滚屏显示（否：0；是：1）
	 */
	public int Socroll
	{
		set { _socroll = value; }
	    get { return _socroll; }
	}
	
	/**
	 * 是否显示叹号（否：0；是：1）
	 */
	public int Prompting
	{
		set { _prompting = value; }
	    get { return _prompting; }
	}
	
	/**
	 * 优先级(1到99)
	 */
	public int Priority
	{
		set { _priority = value; }
	    get { return _priority; }
	}
	
	
	public override int GetId() 
	{
		return 307106;
	}
}