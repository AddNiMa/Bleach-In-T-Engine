using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * buff信息 message
 */
public class ResBuffInfoMessage : Message 
{
	//buff信息
	List<BuffInfo> _buffInfo = new List<BuffInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//buff信息
		SerializeUtils.WriteShort(stream, (short)_buffInfo.Count);

		foreach (var element in _buffInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//buff信息
		int _buffInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _buffInfo_length; ++i) 
		{
			_buffInfo.Add(SerializeUtils.ReadBean<BuffInfo>(stream));
		}
	}
	
	/**
	 * get buff信息
	 * @return 
	 */
	public List<BuffInfo> GetBuffInfo()
	{
		return _buffInfo;
	}
	
	/**
	 * set buff信息
	 */
	public void SetBuffInfo(List<BuffInfo> buffInfo)
	{
		_buffInfo = buffInfo;
	}
	
	
	public override int GetId() 
	{
		return 203300;
	}
}