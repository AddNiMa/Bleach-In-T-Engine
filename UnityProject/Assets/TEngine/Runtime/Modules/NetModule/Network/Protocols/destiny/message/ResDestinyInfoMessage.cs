using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 宿命对决信息 message
 */
public class ResDestinyInfoMessage : Message 
{
	//下次刷新时间
	int _nextRefreshTime;	
	//对手信息
	List<DestinyInfo> _infos = new List<DestinyInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//下次刷新时间
		SerializeUtils.WriteInt(stream, _nextRefreshTime);
		//对手信息
		SerializeUtils.WriteShort(stream, (short)_infos.Count);

		foreach (var element in _infos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//下次刷新时间
		_nextRefreshTime = SerializeUtils.ReadInt(stream);
		//对手信息
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<DestinyInfo>(stream));
		}
	}
	
	/**
	 * 下次刷新时间
	 */
	public int NextRefreshTime
	{
		set { _nextRefreshTime = value; }
	    get { return _nextRefreshTime; }
	}
	
	/**
	 * get 对手信息
	 * @return 
	 */
	public List<DestinyInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 对手信息
	 */
	public void SetInfos(List<DestinyInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 107101;
	}
}