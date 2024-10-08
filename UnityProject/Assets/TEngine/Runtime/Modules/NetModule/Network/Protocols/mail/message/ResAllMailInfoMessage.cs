using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 全部邮件 message
 */
public class ResAllMailInfoMessage : Message 
{
	//邮件具体信息
	List<MailInfo> _mailInfo = new List<MailInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//邮件具体信息
		SerializeUtils.WriteShort(stream, (short)_mailInfo.Count);

		foreach (var element in _mailInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//邮件具体信息
		int _mailInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _mailInfo_length; ++i) 
		{
			_mailInfo.Add(SerializeUtils.ReadBean<MailInfo>(stream));
		}
	}
	
	/**
	 * get 邮件具体信息
	 * @return 
	 */
	public List<MailInfo> GetMailInfo()
	{
		return _mailInfo;
	}
	
	/**
	 * set 邮件具体信息
	 */
	public void SetMailInfo(List<MailInfo> mailInfo)
	{
		_mailInfo = mailInfo;
	}
	
	
	public override int GetId() 
	{
		return 500105;
	}
}