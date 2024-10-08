using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应百万招财积分系统基础信息 message
 */
public class ResMillionInfoMessage : Message 
{
	//百万招财系统是否开启[0:未开启,1:开启]
	int _open;	
	//百万招财系统还有多少结束[0:未开启,大于0:剩余秒数]
	long _closeSeconds;	
	//奖池内累计的魂玉数量
	long _soul;	
	//在售列表
	List<int> _sellingList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//百万招财系统是否开启[0:未开启,1:开启]
		SerializeUtils.WriteInt(stream, _open);
		//百万招财系统还有多少结束[0:未开启,大于0:剩余秒数]
		SerializeUtils.WriteLong(stream, _closeSeconds);
		//奖池内累计的魂玉数量
		SerializeUtils.WriteLong(stream, _soul);
		//在售列表
		SerializeUtils.WriteShort(stream, (short)_sellingList.Count);

		foreach (var element in _sellingList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//百万招财系统是否开启[0:未开启,1:开启]
		_open = SerializeUtils.ReadInt(stream);
		//百万招财系统还有多少结束[0:未开启,大于0:剩余秒数]
		_closeSeconds = SerializeUtils.ReadLong(stream);
		//奖池内累计的魂玉数量
		_soul = SerializeUtils.ReadLong(stream);
		//在售列表
		int _sellingList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _sellingList_length; ++i) 
		{
			_sellingList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 百万招财系统是否开启[0:未开启,1:开启]
	 */
	public int Open
	{
		set { _open = value; }
	    get { return _open; }
	}
	
	/**
	 * 百万招财系统还有多少结束[0:未开启,大于0:剩余秒数]
	 */
	public long CloseSeconds
	{
		set { _closeSeconds = value; }
	    get { return _closeSeconds; }
	}
	
	/**
	 * 奖池内累计的魂玉数量
	 */
	public long Soul
	{
		set { _soul = value; }
	    get { return _soul; }
	}
	
	/**
	 * get 在售列表
	 * @return 
	 */
	public List<int> GetSellingList()
	{
		return _sellingList;
	}
	
	/**
	 * set 在售列表
	 */
	public void SetSellingList(List<int> sellingList)
	{
		_sellingList = sellingList;
	}
	
	
	public override int GetId() 
	{
		return 316104;
	}
}