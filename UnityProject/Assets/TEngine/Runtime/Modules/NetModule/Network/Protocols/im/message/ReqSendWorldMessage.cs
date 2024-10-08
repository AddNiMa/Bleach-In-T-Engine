using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求发送世界消息 message
 */
public class ReqSendWorldMessage : Message 
{
	//0:普通聊天,1:语音聊天
	int _type;	
	//消息内容
	string _content;	
	//格式化消息内容的占位符(%s)参数(文字链接，文字加粗，颜色等)
	List<string> _formatParams = new List<string>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:普通聊天,1:语音聊天
		SerializeUtils.WriteInt(stream, _type);
		//消息内容
		SerializeUtils.WriteString(stream, _content);
		//格式化消息内容的占位符(%s)参数(文字链接，文字加粗，颜色等)
		SerializeUtils.WriteShort(stream, (short)_formatParams.Count);

		foreach (var element in _formatParams)  
		{
			SerializeUtils.WriteString(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:普通聊天,1:语音聊天
		_type = SerializeUtils.ReadInt(stream);
		//消息内容
		_content = SerializeUtils.ReadString(stream);
		//格式化消息内容的占位符(%s)参数(文字链接，文字加粗，颜色等)
		int _formatParams_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _formatParams_length; ++i) 
		{
			_formatParams.Add(SerializeUtils.ReadString(stream));
		}
	}
	
	/**
	 * 0:普通聊天,1:语音聊天
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 消息内容
	 */
	public string Content
	{
		set { _content = value; }
	    get { return _content; }
	}
	
	/**
	 * get 格式化消息内容的占位符(%s)参数(文字链接，文字加粗，颜色等)
	 * @return 
	 */
	public List<string> GetFormatParams()
	{
		return _formatParams;
	}
	
	/**
	 * set 格式化消息内容的占位符(%s)参数(文字链接，文字加粗，颜色等)
	 */
	public void SetFormatParams(List<string> formatParams)
	{
		_formatParams = formatParams;
	}
	
	
	public override int GetId() 
	{
		return 307203;
	}
}